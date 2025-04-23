using king_me.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace king_me.Interfaces
{
    public interface ITabuleiroService
    {
        void MoverPersonagem(Panel pnl, string personagem, int setor);
        int? ObterSetorAtual(string personagem);
        void LimparTabuleiro(Panel pnl);
        void AtualizarTabuleiro(Panel pnl, string statusTabuleiro);
        void RemoverPersonagem(Panel pnl, string personagem);
        void LimparSetor10(Panel pnl);
        int ObterSetorNãoCheio();
        List<int> ObterSetoresNaoCheios(int idPartida);
        bool IsSetorCheio(int setor, int idPartida);
    }
}
