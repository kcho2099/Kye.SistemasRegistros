using Kye.SistemasRegistros.CasosUso.Usuarios;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddUseCaseServices(this IServiceCollection services)
    {
        services.AddScoped<AgregarUsuario>();
        return services;
    }


}

