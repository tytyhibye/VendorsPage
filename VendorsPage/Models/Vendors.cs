using System.Collections.Generic;

namespace VendorsPage.Models
{
  public class Vendors
  {
    private static List<Vendors> _instances = new List<Vendors> {};
    
    public string Description { get; set; }
    public string Name { get; set; }
    public int Id { get; }
    public List<Orders> Orders { get; set; } // Auto-implemented property with Orders delcaring the data type as a list
  
    public Vendors(string vendorName) // The constructor only accepts an argument for vendorsName, which is assigned to the Name property.
    {
      Name = vendorName;
      _instances.Add(this);  // All other properties are assigned automatically in the body of the constructor.
      Id = _instances.Count;
      Orders = new List<Orders>{};
    }

    public Vendors(string vendorName, string vendorDescription)
    {
      Description = vendorDescription; // overloaded constructor for optional description field.
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