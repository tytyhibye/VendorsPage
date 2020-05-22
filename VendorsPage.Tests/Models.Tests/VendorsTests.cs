using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorsPage.Models;
using System.Collections.Generic;
using System;

namespace VendorsPage.Tests
{
  [TestClass]
  public class VendorsTest : IDisposable
  {
    public void Dispose()
    {
      Vendors.ClearAll();
    }

    [TestMethod]
    public void VendorsConstructor_CreatesInstanceOfVendors_Vendors()
    {
      Vendors newVendor = new Vendors("test vendor");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }

   [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendors newVendor = new Vendors(name);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendors newVendor = new Vendors(name);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }
  
  
  }
}