using Autofac;

namespace TestApp.Providers
{
  public class IocBuilder
  {
    public static IContainer Build()
    {
      var builder = new ContainerBuilder();
      builder.RegisterType<VehicleProvider>().As<IVehicleProvider>();
      return builder.Build();
    }
  }
}
