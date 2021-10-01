using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresWholesale.Models;
using System;

namespace PierresWholesale.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    //1
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Sarah's Bad Bakery", "Sells Half-Buns and Orts");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    //2
    [TestMethod]
    public void GetNameNDetails_ReturnsNameNDetails_StringString()
    {
      string name = "Sarah's Rotten Bunnery";
      string details = "Not a whole bun in the lot";
      Vendor newVendor = new Vendor(name, details);

      string nameResult = newVendor.Name;
      string detailsResult = newVendor.Details;

      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(details, detailsResult);
    }
    //3
    [TestMethod]
    public void GetId_VendorsInstantiateWithIdGetReturnsId_Int()
    {
      string name = "Bunsville";
      string details = "Manager Miche is a jerk";
      Vendor newVendor = new Vendor(name, details);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }
    //4
    [TestMethod]
    public void ChangeNameNDetails_ChangeNameNDetails_StringString()
    {
      string name = "Sarah's Rotten Bunnery";
      string details = "Not a whole bun in the lot";
      Vendor newVendor = new Vendor(name, details);

      string updatedName = "Sarah's Better Bunnery";
      string updatedDetails = "Rebrand fairly unsuccessful. Buns still rotten.";
      newVendor.Name = updatedName;
      newVendor.Details = updatedDetails;
      string nameResult = newVendor.Name;
      string detailsResult = newVendor.Details;

      Assert.AreEqual(updatedName, nameResult);
      Assert.AreEqual(updatedDetails, detailsResult);
    }

    //5
    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newVendorList = new List<Vendor> {};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newVendorList, result);
    }

    //6
    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      string name1 = "The Miche Quiche";
      string details1 = "Doesn't sell quiche";
      string name2 = "Orts 'n' Things";
      string details2 = "Sells orts 'n' things";
      Vendor newVendor1 = new Vendor(name1, details1);
      Vendor newVendor2 = new Vendor(name2, details2);
      List<Vendor> newVendorList = new List<Vendor> {newVendor1, newVendor2};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newVendorList, result);
    }

    //7
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "The Miche Quiche";
      string details1 = "Doesn't sell quiche";
      string name2 = "Orts 'n' Things";
      string details2 = "Sells orts 'n' things";
      Vendor newVendor1 = new Vendor(name1, details1);
      Vendor newVendor2 = new Vendor(name2, details2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    //15
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderName = "Ratloaves";
      string orderDetails = "1000 rat-eaten loaves";
      int orderPrice = 100;
      string orderDate = "10/30/2021";
      Order newOrder = new Order(orderName, orderDetails, orderPrice, orderDate);
      List<Order> newList = new List<Order> {newOrder};
      string name = "Sarah's Rotten Bunnery";
      string details = "Not a whole bun in the lot";
      Vendor newVendor = new Vendor(name, details);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}