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

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Panet Shaped Bread";
      Orders newOrder = new Orders(description);
      //Act
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDecription_SetDescription_string()
    {
      //Arrange
      string description = "Planet Shaped Bread";
      Orders newOrder = new Orders(description);

      //Act
      string updatedDescription = "Sun Shaped Bread";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

     [TestMethod]
    public void GetAll_ReturnsEmptyList_OrdersList()
    {
      // Arrange
      List<Orders> newList = new List<Orders> { };

      // Act
      List<Orders> result = Orders.GetAll();
      foreach (Orders thisOrder in result)
      {
        Console.WriteLine("Output from empty list GetAll test: " + thisOrder.Description);
      }
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrdersList()
    {
      //Arrange
      string description01 = "Planet Shaped Bread";
      string description02 = "Sun Shaped Bread";
      Orders newOrder1 = new Orders(description01);
      Orders newOrder2 = new Orders(description02);
      List<Orders> newList = new List<Orders> {newOrder1, newOrder2};

      //Act
      List<Orders> result = Orders.GetAll();
      foreach (Orders thisOrder in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisOrder.Description);
      }

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string description = "Planet Shaped Bread";
      Orders newOrder = new Orders(description);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

     [TestMethod]
  public void Find_ReturnsCorrectOrders_Orders()
  {
    //Arrange
    string description01 = "Planet Shaped Bread";
    string description02 = "Sun Shaped Bread";
    Orders newOrder1 = new Orders(description01);
    Orders newOrder2 = new Orders(description02);

    //Act
    Orders result = Orders.Find(2);

    //Assert
    Assert.AreEqual(newOrder2, result);
  }
  }
}