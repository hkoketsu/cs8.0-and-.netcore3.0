using Microsoft.ML.Data;

namespace NorthwindML.Models
{
  public class ProductCobought
  {
    [KeyType(77)] // maximum possible value of a product id
    public uint ProductID {get; set;}
    
    [KeyType(77)]
    public uint CoboughtProductID {get;set;}
  }
}