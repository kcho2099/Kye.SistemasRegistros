using Kye.SistemasRegistros.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Kye.SistemasRegistros.Win;

public class Navegacion
{
    private readonly IServiceProvider _serviceProvider;
    public Navegacion(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Navegar<T>(Control Parent) where T : class
    {
        HelperScoped.ScopeActual = _serviceProvider.CreateScope();
        HelperScoped.FormActual = HelperScoped.ScopeActual.ServiceProvider.GetRequiredService<T>();

        if (HelperScoped.FormActual is Form formHijo)
        {
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            Parent.Controls.Add(formHijo);
            Parent.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
    }
}
