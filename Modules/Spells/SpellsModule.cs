public class SpellsModule : IModule
{

  private readonly String endpoint = "/spells";
  public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
  {
    endpoints.MapGet($"{endpoint}", () =>
    {
      return "hello";
    });
    endpoints.MapPost($"{endpoint}", () => { });

    return endpoints;
  }

  public IServiceCollection RegisterModule(IServiceCollection services)
  {
    return services;
  }
}