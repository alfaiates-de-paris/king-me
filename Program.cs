using king_me.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace king_me
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create instances of the services
            var partidaService = new Services.PartidaService();
            var jogadorService = new Services.JogadorService();
            var cartaService = new Services.CartaService();
            var votoService = new VotoService();

            // Run the application with the KingMe form, injecting the dependencies
            Application.Run(new KingMe(partidaService, jogadorService, cartaService,votoService));
        }
    }
}
