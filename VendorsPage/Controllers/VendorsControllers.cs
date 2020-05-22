using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorsPage.Models;

namespace VendorsPage.Controllers
{
  public class VendorsController : Controller
  {
    
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendors> allVendors = Vendors.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")] // Creates vendors
    public ActionResult Create(string vendorName)
    {
      Vendors newVendor = new Vendors(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>(); // Create a new Dictionary called model because a Dictionary can hold multiple key-value pairs.
      Vendors selectedVendors = Vendors.Find(id);
      List<Orders> vendorsOrders = selectedVendors.Orders; // Add both the Vendors and its associated Orders to this Dictionary.
      model.Add("vendors", selectedVendors); // These will be stored with the keys "Vendors" and "Orders".
      model.Add("orders", vendorsOrders);
      return View(model); // The Dictionary, which is named model, will be passed into View().
    }
    // This one creates new Orders within a given Vendors, not new vendors:
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription, int price) // The method now takes two arguments: the VendorsId we passed into a hidden form field and an OrdersDescription that contains the user's form input.
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendors foundVendors = Vendors.Find(vendorId); // Using the VendorsId provided as an argument, we locate the Vendors object our new Orders should belong to and call it foundVendors.
      Orders newOrder = new Orders(orderDescription, price); // We then create a new Orders object with the user's form input.
      foundVendors.AddOrder(newOrder); // We add the newOrders to the foundVendors with our existing AddOrders() method.
      List<Orders> vendorsOrders = foundVendors.Orders; // We retrieve all other Orders that corresponds to this Vendors and add it to our model. We do this because the view we'll render at the end of this route requires this information.
      model.Add("orders", vendorsOrders);
      model.Add("vendors", foundVendors); // We also add the foundVendors to our model.
      return View("show", model); // Finally, we pass in our model data to View(), instructing it to render the Vendors detail page, which is the Show.cshtml view.
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendors.ClearAll();
      return View();
    }
  }
}