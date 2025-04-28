using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace king_me.Models
{
    public class ResultadoVotoDTO
    {
        private string voto;
        private string status;
        private int idJogador;

        public string Voto
        {
            get { return voto; }
        }

        public string Status
        {
            get { return status; }
        }

        public int IdJogador
        {
            get { return idJogador; }
        }

        public ResultadoVotoDTO(string voto, string status, int idJogador)
        {
            this.voto = voto;
            this.status = status;
            this.idJogador = idJogador;
        }
    }
}
