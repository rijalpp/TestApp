using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.DTO;

namespace TestApp.Providers
{
  interface IVehicleProvider
  {
    List<Vehicle> GetVehicleList();
  }
}
