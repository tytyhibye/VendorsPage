using System.Collections.Generic;

namespace VendorsPage.Models
{
  public class Vendors
  {
    private static List<Vendors> _instances = new List<Vendors> {};
    
    public string Description { get; set; }
    public string Name { get; set; }
    public int Id { get; }
    public List<Orders> Orders { get; set; }
  
    public Vendors(string vendorName)    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Orders>{};
    }

    public Vendors(string vendorName, string vendorDescription)
    {
      Description = vendorDescription;
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Orders>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendors> GetAll()
    {
      return _instances;
    }

    public static Vendors Find(int searchId)
    {
      return _instances[searchId -1];
    }

    public void AddOrder(Orders order)
    {
      Orders.Add(order);
    }
  }
}