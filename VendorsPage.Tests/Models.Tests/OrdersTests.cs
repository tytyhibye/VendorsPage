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
  }
}