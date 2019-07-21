using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using TestApp.DTO;

namespace TestApp.Providers
{
  public class VehicleProvider : IVehicleProvider
  {
    /// <summary>
    /// Loads the json file into memory and deserialises the json data to the list of vehicle.
    /// </summary>    
    public List<Vehicle> GetVehicleList()
    {
      var currentDir = Directory.GetCurrentDirectory();
      using (var ms = new MemoryStream(File.ReadAllBytes(Path.Combine( Directory.GetCurrentDirectory(), "Resources", "Vehicles.json"))))
      {
        var vehicles = new List<Vehicle>();
        var serialisation = new DataContractJsonSerializer(vehicles.GetType());
        vehicles = serialisation.ReadObject(ms) as List<Vehicle>;
        ms.Close();
        return vehicles;
      }
    }
  }
}
