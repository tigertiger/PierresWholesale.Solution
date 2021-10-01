using System.Collections.Generic;
namespace PierresWholesale.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Details { get; set; }
    public int Id { get; }
    private static List<Vendor> _customers = new List<Vendor> {};
    public List<Order> Orders { get; set; }

    public Vendor (string name, string details)
    {
      Name = name;
      Details = details;
      _customers.Add(this);
      Id = _customers.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _customers.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _customers;
    }

    public static Vendor Find(int searchId)
    {
      return _customers[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}