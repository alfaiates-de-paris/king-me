using System.Web;

namespace king_me.Models
{
    class VotoDTO
    {
        public int IdJogador { get; set; }
        public string Senha { get; set; }
        public string Opcao { get; set; }



    public bool EhValido()
        {
            return Opcao == "S" || Opcao == "N";
        }
    }
}
