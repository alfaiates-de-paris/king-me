using king_me.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace king_me
{
    public partial class HomeForm: Form
    {

        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnHomeJogar_Click(object sender, EventArgs e)
        {
            var partidaService = new Services.PartidaService();
            var jogadorService = new Services.JogadorService();

            Lobby formLobby = new Lobby(partidaService, jogadorService);
            formLobby.ShowDialog();
        }
    }
}
