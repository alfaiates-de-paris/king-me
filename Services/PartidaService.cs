using king_me;
using king_me.Interfaces;
using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace king_me.Services
{
    public class PartidaService : IPartidaService
    {
        public string ListarPartidas(string status)
        {
            return Jogo.ListarPartidas(status);
        }

        public string CriarPartida(string nome, string senha, string grupo)
        {
            return Jogo.CriarPartida(nome, senha, grupo);
        }

        public void Iniciar(int idJogador, string senhaJogador)
        {
            Jogo.Iniciar(idJogador, senhaJogador);
        }

        public string AtualizarPlacar(IJogadorService _jogadorService, string idPartida)
        {
            string retornoDLL = _jogadorService.ListarJogadores(int.Parse(idPartida));
            string[] jogadores = retornoDLL.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            // cria uma lista de tuplas (nome, pontos)
            var listaPlacar = new List<Tuple<string, int>>();
            foreach (string jogador in jogadores)
            {
                string[] partes = jogador.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (partes.Length >= 3 && int.TryParse(partes[2], out int pontos))
                {
                    listaPlacar.Add(Tuple.Create(partes[1], pontos));
                }
            }

            // ordena de forma decrescente pelos pontos
            var placarOrdenado = listaPlacar.OrderByDescending(t => t.Item2).ToList();

            string textoPlacar = "";
            foreach (var item in placarOrdenado)
            {
                textoPlacar += $"Jogador: {item.Item1}, pontos: {item.Item2}\r\n\r\n";
            }

            return textoPlacar;
        }

        public string GetGanhador(TextBox placar) {
            string retorno;
            string textoPlacar = placar.Text;

            string[] jogadores = textoPlacar.Split(new[] { "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (jogadores.Length > 0 && jogadores[0].Contains(","))
            {
                string[] partes = jogadores[0].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (partes.Length > 1)
                {
                    retorno = $"Ganhador: {partes[0]}, {partes[1]}! Parabéns!!";
                }
                else
                {
                    retorno = "Formato do placar inválido.";
                }
            }
            else
            {
                retorno = "Placar vazio ou inválido.";
            }

            return retorno;
        }
    }
}


