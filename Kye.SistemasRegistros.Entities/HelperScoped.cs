using Microsoft.Extensions.DependencyInjection;


namespace Kye.SistemasRegistros.Entities;

public static class HelperScoped
{
    public static IServiceScope ScopeActual { get; set; }
    public static object FormActual { get; set; }
    
}
