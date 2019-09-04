using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnJogadorAtual.Text = Jogo.JogadorAtual();
            btnJogadorProximo.Text = Jogo.JogadorProximo();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string jogador = Jogo.JogadorAtual();

            var botao = (Button)sender;
            botao.Text = jogador;

            int posicao = botao.Name.Last() - '0';
            posicao--;

            Jogo.RealizarJogada(posicao, jogador);
            string vencedor = Jogo.VerificarVencedor();

            if (vencedor != "")
            {
                MessageBox.Show(vencedor);

                if (vencedor == "X")
                {
                    var placar = int.Parse(btnPlacarX.Text);
                    placar++;

                    btnPlacarX.Text = placar.ToString();
                }
                else
                {
                    var placar = int.Parse(btnPlacarBola.Text);
                    placar++;

                    btnPlacarBola.Text = placar.ToString();
                }
            }

            btnJogadorAtual.Text = Jogo.JogadorAtual();
            btnJogadorProximo.Text = Jogo.JogadorProximo();
            botao.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Jogo.Reiniciar();

            btnJogadorAtual.Text = Jogo.JogadorAtual();
            btnJogadorProximo.Text = Jogo.JogadorProximo();

            ReiniciarBotao(button1);
            ReiniciarBotao(button2);
            ReiniciarBotao(button3);
            ReiniciarBotao(button4);
            ReiniciarBotao(button5);
            ReiniciarBotao(button6);
            ReiniciarBotao(button7);
            ReiniciarBotao(button8);
            ReiniciarBotao(button9);
        }

        private void ReiniciarBotao(Button btn)
        {
            btn.Enabled = true;
            btn.Text = " - ";
        }
    }
}
