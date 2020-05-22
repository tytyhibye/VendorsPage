using Microsoft.AspNetCore.Mvc;
using VendorsPage.Models;
using System.Collections.Generic;

namespace VendorsPage.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")] // The path now includes vendors information, which ensures our routes are now RESTfully named.
    public ActionResult Show(int vendorId, int orderId) // Because the path includes both order and vendors IDs, we can locate the correct parent and child objects and pass them to our view in a Dictionary.
    {
      Orders order = Orders.Find(orderId);
      Vendors vendor = Vendors.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendors", vendor);
      return View(model);
    }


    [HttpGet("/vendors/{vendorId}/orders/new")] // The path now includes the ID of the vendor we're adding a new order to. Because it's in curly braces, we can grab this in our route's parameter to locate the vendor object and pass it into the corresponding view
    public ActionResult New(int vendorId)
    {
      Vendors vendor = Vendors.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Orders.ClearAll();
      return View();
    }
  }
}