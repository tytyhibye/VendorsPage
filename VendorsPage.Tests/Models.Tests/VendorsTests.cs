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
      Vendors newVendors = new Vendors("test vendor");
      Assert.AreEqual(typeof(Vendors), newVendors.GetType());
    }

   [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendors newVendors = new Vendors(name);

      string result = newVendors.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorsId_Int()
    {
      string name = "Test Vendor";
      Vendors newVendors = new Vendors(name);

      int result = newVendors.Id;

      Assert.AreEqual(1, result);
    }
  
  
  }
}