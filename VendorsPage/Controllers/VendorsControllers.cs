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

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendors newVendor = new Vendors(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendors selectedVendors = Vendors.Find(id);
      List<Orders> vendorsOrders = selectedVendors.Orders;
      model.Add("vendors", selectedVendors);
      model.Add("orders", vendorsOrders);
      return View(model);
    }
    
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription, double orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendors foundVendors = Vendors.Find(vendorId);
      Orders newOrder = new Orders(orderDescription, orderPrice);
      foundVendors.AddOrder(newOrder); 
      List<Orders> vendorsOrders = foundVendors.Orders;
      model.Add("orders", vendorsOrders);
      model.Add("vendors", foundVendors);
      return View("show", model);
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendors.ClearAll();
      return View();
    }
  }
}