using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresWholesale.Models;
using System;

namespace PierresWholesale.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    //8
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Sunday Bunday", "300 half-buns", 450, "10/2/2021");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    //9
    [TestMethod]
    public void GetOrderProperties_ReturnsOrderProperties_StringStringIntString()
    {
      string orderName = "Sunday Bunday";
      string orderDetails = "300 half-buns";
      int orderPrice = 450;
      string orderDate = "10/2/2021";

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

    //10
    [TestMethod]
    public void ChangeOrderProperties_ChangeOrderProperties_StringStringIntString()
    {
      string orderName = "Sunday Bunday";
      string orderDetails = "300 half-buns";
      int orderPrice = 450;
      string orderDate = "10/2/2021";
      Order newOrder = new Order(orderName, orderDetails, orderPrice, orderDate);

      string updatedName = "Monday Bunday";
      string updatedDetails = "100 half-buns";
      int updatedPrice = 150;
      string updatedDate = "10/3/2021";

      newOrder.OrderName = updatedName;
      newOrder.OrderDetails = updatedDetails;
      newOrder.OrderPrice = updatedPrice;
      newOrder.OrderDate = updatedDate;

      string nameResult = newOrder.OrderName;
      string detailsResult = newOrder.OrderDetails;
      int priceResult = newOrder.OrderPrice;
      string dateResult = newOrder.OrderDate;

      Assert.AreEqual(updatedName, nameResult);
      Assert.AreEqual(updatedDetails, detailsResult);
      Assert.AreEqual(updatedPrice, priceResult);
      Assert.AreEqual(updatedDate, dateResult);
    }

    //11
    [TestMethod]
    public void GetId_OrdersInstantiateWithIdGetReturns_Int()
    {
      string orderName = "Sunday Bunday";
      string orderDetails = "300 half-buns";
      int orderPrice = 450;
      string orderDate = "10/2/2021";
      Order newOrder = new Order(orderName, orderDetails, orderPrice, orderDate);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    //12
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderName1 = "Sunday Bunday";
      string orderDetails1 = "300 half-buns";
      int orderPrice1 = 450;
      string orderDate1 = "10/2/2021";
      Order newOrder1 = new Order(orderName1, orderDetails1, orderPrice1, orderDate1);

      string orderName2 = "Ratloaves";
      string orderDetails2 = "1000 rat-eaten loaves";
      int orderPrice2 = 100;
      string orderDate2 = "10/30/2021";
      Order newOrder2 = new Order(orderName2, orderDetails2, orderPrice2, orderDate2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

    //13
    [TestMethod]
    public void GetAll_ReturnsEmptyOrderList_OrderList()
    {
      List<Order> newOrderList = new List<Order> {};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrderList, result);
    }

    //14
    [TestMethod]
    public void GetAll_ReturnsPopulatedOrderList_OrderList()
    {
      string orderName1 = "Sunday Bunday";
      string orderDetails1 = "300 half-buns";
      int orderPrice1 = 450;
      string orderDate1 = "10/2/2021";
      Order newOrder1 = new Order(orderName1, orderDetails1, orderPrice1, orderDate1);

      string orderName2 = "Ratloaves";
      string orderDetails2 = "1000 rat-eaten loaves";
      int orderPrice2 = 100;
      string orderDate2 = "10/30/2021";
      Order newOrder2 = new Order(orderName2, orderDetails2, orderPrice2, orderDate2);

      List<Order> newList = new List<Order> {newOrder1, newOrder2};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

  }
}