using System.Collections.Generic;
namespace PierresWholesale.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Details { get; set; }
    public int Id { get ;}

    public Vendor (string name, string details)
    {
      Name = name;
      Details = details;
    }
  }
}