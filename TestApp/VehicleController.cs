using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using TestApp.DTO;
using TestApp.Providers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApp
{
  [Route("api/[controller]")]
  public class VehicleController : Controller
  {
    // GET: api/<controller>
    [HttpGet]
    public List<Vehicle> GetVehicleList()
    {
      return IocBuilder.Build().Resolve<IVehicleProvider>().GetVehicleList();
    }
  }
}
