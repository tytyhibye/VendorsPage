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

    [HttpPost("/vendors")] // Creates Vendors
    public ActionResult Create(string vendorsName)
    {
      Vendors newVendors = new Vendors(vendorsName);
      return RedirectToAction("Index");
    }

  }
}