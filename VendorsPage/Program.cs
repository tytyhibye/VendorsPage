using System.IO;
using Microsoft.AspNetCore.Hosting;
using MusicVendorsPage.Models;


namespace MusicOrganizer
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();
      
      host.Run();
    }
  }
} 