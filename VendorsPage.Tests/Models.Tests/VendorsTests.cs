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
  }
}