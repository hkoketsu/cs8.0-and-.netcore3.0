using Microsoft.AspNetCore.Mvc;
using Packt.Shared;
using NorthwindService.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NorthwindService.Controllers
{
  // base address: api/customers
  [Route("api/[controller]")]
  [ApiController]
  public class CustomersController : ControllerBase
  {
    private ICustomerRepository repository;
    
    // constructor injects repository registered in startup
    public CustomersController(ICustomerRepository repository)
    {
      this.repository = repository;
    }

    // GET: api/customers
    // GET: api/customers/?country=[country]
    // this will always reutrn a list of customers even if it is empty
    [HttpGet]
    [ProducesResponseType(200, Type=typeof(IEnumerable<Customer>))]
    public async Task<IEnumerable<Customer>> GetCustomers(string country)
    {
      if (string.IsNullOrWhiteSpace(country))
      {
        return await repository.RetrieveAllAsync();
      }
      return (await repository.RetrieveAllAsync())
          .Where(customer => customer.Country == country);
    }

    // GET: api/customers/[id]
    [HttpGet("{id}", Name = nameof(GetCustomer))] // named route
    [ProducesResponseType(200, Type = typeof(Customer))]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetCustomer(string id)
    {
      Customer c = await repository.RetrieveAsync(id);
      if (c == null)
      {
        return NotFound();
      }
      return Ok(c);
    }

    // POST: api/customers
    // BODY: Customer (JSON, XML)
    [HttpPost]
    [ProducesResponseType(201, Type = typeof(Customer))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] Customer c)
    {
      if (c == null) return BadRequest(); // 400 Bad request
      if (!ModelState.IsValid) return BadRequest(ModelState); // 400
      
      Customer added = await repository.CreateAsync(c);
      return CreatedAtRoute(
        routeName: nameof(GetCustomer),
        routeValues: new { id = added.CustomerID.ToLower() },
        value: added
      );
    }

    // PUT: api/customers/[id]
    // BODY: Customer (JSON, XML)
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update(string id, [FromBody] Customer c)
    {
      id = id.ToUpper();
      c.CustomerID = c.CustomerID.ToUpper();
      
      if (c == null || c.CustomerID != id) return BadRequest(); // 400 Bad Request
      if (!ModelState.IsValid) return BadRequest(ModelState);

      var existing = await repository.RetrieveAsync(id);
      if (existing == null) return NotFound();

      await repository.UpdateAsync(id, c);
      return new NoContentResult(); // 204 No content
    }

    // DELETE: api/customers/[id]
    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(string id)
    {
      if (id == "bad")
      {
        var problemDetails = new ProblemDetails
        {
          Status = StatusCodes.Status400BadRequest,
          Type = "https://localhost:5001/customers/failed-to-delete",
          Title = $"Customer ID {id} found but failed to delete.",
          Detail = "More details like Company Name, Country and so on.",
          Instance = HttpContext.Request.Path
        };
        return BadRequest(problemDetails);
      }

      var exising = await repository.RetrieveAsync(id);
      if (exising == null)
      {
        return NotFound();
      }

      bool? deleted = await repository.DeleteAsync(id);
      if (deleted.HasValue && deleted.Value) // short circuit AND
      {
        return new NoContentResult(); // 204
      }
      return BadRequest(
        $"Customer {id} was found but failed to delete"
      );
    }
  }
}