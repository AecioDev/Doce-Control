using GS.API.Data.Interfaces;
using GS.API.Data.Repositorios;
using GS.WIN.Shared;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GS.WIN
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Acesso());
        }
    }

    //public class Startup
    //{
    //    public void ConfigureServices(IServiceCollection services)
    //    {
            
    //        services.AddScoped<IClienteRep, ClienteRep>();

    //    }
    //}
}
