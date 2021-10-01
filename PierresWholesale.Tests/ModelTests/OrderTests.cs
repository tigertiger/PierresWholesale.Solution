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
  }
}