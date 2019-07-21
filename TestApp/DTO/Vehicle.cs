using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TestApp.DTO
{
  [DataContract]
  public class Vehicle
  {
    [DataMember]
    public string Make { get; set; }

    [DataMember]
    public string Model { get; set; }

    [DataMember]
    public int  Year { get; set; }

    [DataMember]
    public string LicencePlate { get; set; }

    [DataMember]
    public string State { get; set; }
  }
}
