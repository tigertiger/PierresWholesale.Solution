using System.Collections.Generic;
namespace PierresWholesale.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Details { get; set; }
    public int Id { get; }
    private static List<Vendor> _customers = new List<Vendor> {};

    public Vendor (string name, string details)
    {
      Name = name;
      Details = details;
      _customers.Add(this);
      Id = _customers.Count;
    }

    public static void ClearAll()
    {
      _customers.Clear();
    }
  }
}