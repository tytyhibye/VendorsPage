using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorsPage.Models;

namespace VendorsPage.Tests
{
  [TestClass]
  public class OrdersTests : IDisposable
  {
    public void Dispose()
    {
      Orders.ClearAll();
    }

    [TestMethod]
    public void OrdersConstructor_CreatesInstanceOfOrder_Orders()
    {
      Orders newOrder = new Orders("test");
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }

  }
}