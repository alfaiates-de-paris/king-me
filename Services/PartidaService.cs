using System.Linq;
using System.Windows.Forms;
using System;
using king_me.Interfaces;
using KingMeServer;
using king_me.Models;

namespace king_me.Services
{
    public class PartidaService : IPartidaService
    {
        int idJogador;
        string senhaJogador;
        int idPartida;

        public string ListarPartidas(string status)
        {
            return Jogo.ListarPartidas(status);
        }

        public string CriarPartida(string nome, string senha, string grupo)
        {
            return Jogo.CriarPartida(nome, senha, grupo);
        }

        public void Iniciar(int idJogador, string senhaJogador, int idPartida)
        {
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            this.idPartida = idPartida;
            Jogo.Iniciar(idJogador, senhaJogador);
        }

        public ResultadoVotoDTO VerificarVez(IJogadorService jogadorService, IVotoService votoService)
        {
            string tabuleiro = KingMeServer.Jogo.VerificarVez(this.idPartida);
            string[] linhasTabuleiro = tabuleiro.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            var jogadorDaVez = jogadorService.GetJogadorDaVez(idPartida);

            tabuleiro = string.Join("\r\n", linhasTabuleiro.Skip(1));
            if (tabuleiro.Contains("10"))
            {
                if (idJogador.ToString() == jogadorDaVez.IdJogador)
                {
                    string votoAuto = new Random().Next(2) == 0 ? "S" : "N";
                    string status= votoService.Votar(idJogador, senhaJogador, votoAuto);
                    return new ResultadoVotoDTO(votoAuto, status, idJogador);
                }
                else
                {
                    return null;
                    //MessageBox.Show("É a vez de outro jogador.", "Aguardando troca de jogador", MessageBoxButtons.OK, MessageBoxIcon.Information); //comentar essa linha ao depurar com breakpoint
                }
            }

            return null;
        }
    }
}
