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
        void MoverPersonagem(Panel pnl, string personagem, int setor, int index);
    }
}
