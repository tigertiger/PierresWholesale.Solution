using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresWholesale.Models;
using System;

namespace PierresWholesale.Tests
{
  [TestClass]
  public class OrderTests
  {
    //8
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Sunday Bunday", "300 half-buns", 450, "10/1/2021");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    //9
    [TestMethod]
    public void GetOrderProperties_ReturnsOrderProperties_StringStringIntString()
    {
      string orderName = "Sunday Bunday";
      string orderDetails = "300 half-buns";
      int orderPrice = 450;
      string orderDate = "10/1/2021";

      Order newOrder = new Order(orderName, orderDetails, orderPrice, orderDate);
      string nameResult = newOrder.OrderName;
      string detailsResult = newOrder.OrderDetails;
      int priceResult = newOrder.OrderPrice;
      string dateResult = newOrder.OrderDate;

      Assert.AreEqual(orderName, nameResult);
      Assert.AreEqual(orderDetails, detailsResult);
      Assert.AreEqual(orderPrice, priceResult);
      Assert.AreEqual(orderDate, dateResult);
    }
  }
}