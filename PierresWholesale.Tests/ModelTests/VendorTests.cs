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
      string updatedDetails = "Rebrand fairly unsuccessful";
      newVendor.Name = updatedName;
      newVendor.Details = updatedDetails;
      string nameResult = newVendor.Name;
      string detailsResult = newVendor.Details;

      Assert.AreEqual(updatedName, nameResult);
      Assert.AreEqual(updatedDetails, detailsResult);
    }
  }
}