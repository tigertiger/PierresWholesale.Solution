using System.Collections.Generic;
namespace PierresWholesale.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string OrderDetails { get; set; }
    public int OrderPrice { get; set; }
    public string OrderDate { get; set; }
    public int Id { get; }
    private static List<Order> _orderTracker = new List<Order> {};

    public Order (string orderName, string orderDetails, int orderPrice, string orderDate)
    {
      OrderName = orderName;
      OrderDetails = orderDetails;
      OrderPrice = orderPrice;
      OrderDate = orderDate;
      _orderTracker.Add(this);
      Id = _orderTracker.Count;
    }

    public static void ClearAll()
    {
      _orderTracker.Clear();
    }
  }
}