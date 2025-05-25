using Kye.SistemasRegistros.CasosUso.Contactos;
using Kye.SistemasRegistros.CasosUso.Logos;
using Kye.SistemasRegistros.CasosUso.Miembros;
using Kye.SistemasRegistros.CasosUso.Planes;
using Kye.SistemasRegistros.CasosUso.Usuarios;
using Kye.SistemasRegistros.Repositorio.Models;
using Kye.SistemasRegistros.Win.MembresiasForms;
using Kye.SistemasRegistros.Win.MiembrosForms;
using Kye.SistemasRegistros.Win.Planes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Kye.SistemasRegistros.Win
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureService(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                using (var loginForm = serviceProvider.GetRequiredService<LoginForm>())
                {
                    var result = loginForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        var mainForm = serviceProvider.GetRequiredService<MainForm>(); // Resolver Form1 desde DI
                        Application.Run(mainForm);
                    }
                }
            }


        }

        private static void ConfigureService(IServiceCollection services)
        {
            services.AddDbContext<DBSistemasRegistrosContext>(options =>
            {
                options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BDSistemaRegistro.mdf;Integrated Security=True;Connect Timeout=30;Initial Catalog=BDSistemaRegistro");
            });

            // Registrar la capa de negocio
            services.AddScoped<AgregarUsuario>();
            services.AddScoped<BuscarUsuarios>();
            services.AddScoped<ConsultaUsuarioById>();
            services.AddScoped<UpdateUsuario>();
            services.AddScoped<EliminarUsuario>();
            services.AddScoped<AddLogo>();
            services.AddScoped<ConsultarLogosById>();
            services.AddSingleton<Login>();
            services.AddScoped<BuscarMiembroByNombreId>();
            services.AddScoped<AgregarMiembro>();
            services.AddScoped<BuscarMiembroByStringEmpty>();
            services.AddScoped<ConsultarContactos>();
            services.AddScoped<AddContacto>();
            services.AddScoped<EliminarContacto>();
            services.AddScoped<ActualizarMiembro>();
            services.AddScoped<ConsultarMiembros>();
            services.AddSingleton<Navegacion>();
            services.AddScoped<EliminarMiembro>();
            services.AddScoped<ConsultarPlanes>();
            services.AddScoped<AgregarPlanes>();


            // Registrar Forms
            services.AddSingleton<LoginForm>();
            services.AddSingleton<MainForm>();
            services.AddSingleton<BuscarMiembroForm>();
            services.AddScoped<AgregarMiembroForm>();
            services.AddScoped<DashboardForm>();
            services.AddScoped<ConsultaClientesForm>();
            services.AddScoped<ConsultaMembresiasForm>();
            services.AddScoped<AgregarPlanesForm>();
            services.AddScoped<ConsultarPlanesForm>();            
        }



    }
}