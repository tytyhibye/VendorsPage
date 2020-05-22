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
  
    [TestMethod]
    public void GetAll_ReturnsAllVendorsObjects_VendorList()
    {
      
      string name01 = "Dill Rye the Sandwich Guy";
      string name02 = "The Sand-Witch";
      Vendors newVendor1 = new Vendors(name01);
      Vendors newVendor2 = new Vendors(name02);
      List<Vendors> newList = new List<Vendors> { newVendor1, newVendor2 };

      List<Vendors> result = Vendors.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

     [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Dill Rye the Sandwich Guy";
      string name02 = "The Sand-Witch";
      Vendors newVendor1 = new Vendors(name01);
      Vendors newVendor2 = new Vendors(name02);

      Vendors result = Vendors.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
     [TestMethod]
  public void AddOrder_AssociatesOrderWithVendor_OrderList()
  {
    string description = "Planet Shaped Bread";
    Order newOrder = new Order(description);
    List<Order> newList = new List<Order> { newOrder }; // We create a new Order and add it to a List.
    string name = "Dill Rye the Sandwich Guy";
    Vendors newVendor = new Vendors(name); // Then we create a new Vendors and call the soon-to-be-created AddOrder method upon it, passing in our sample Order.
    newVendor.AddOrder(newOrder); // Next, we call newVendor.Orders, to retrieve the Orders saved in our Vendors.

    List<Order> result = newVendor.Orders; // Finally, we assert that newVendor.Orders should return a List containing our single Order.

    CollectionAssert.AreEqual(newList, result);
  }
  }
}