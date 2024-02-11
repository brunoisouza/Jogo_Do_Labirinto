using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Do_Labirinto
{
    public partial class CincoForm : Form
    {        
        public CincoForm()
        {
            InitializeComponent();
            lblRespostaUm.Visible = false;
            lblRespostaDois.Visible = false;
            btnCima.Visible = false;
            btnDir.Visible = false;
            btnEsq.Visible = false;
            pibVilao.Visible = true;
        }

        int numeroAleatorio;
        bool errou = false; 

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (errou == false) //primeira vez que entra na tela
            {
                //Sortear número aleatório
                Random rdm = new Random();
                numeroAleatorio = rdm.Next(3);

                btnContinuar.Hide();

                if (numeroAleatorio == 0)
                {
                    lblDesafio.Text = "Qual a montanha mais alta da Terra?";
                    lblRespostaUm.Text = "Monte Everest";
                    lblRespostaDois.Text = "Mauna Kea";
                }
                else if (numeroAleatorio == 1)
                {
                    lblDesafio.Text = "Que país tem o formato de uma bota?";
                    lblRespostaUm.Text = "México";
                    lblRespostaDois.Text = "Itália";
                }
                else if (numeroAleatorio == 2)
                {
                    lblDesafio.Text = "Qual o maior planeta do sistema solar?";
                    lblRespostaUm.Text = "Saturno";
                    lblRespostaDois.Text = "Júpiter";
                }
                else
                {
                    lblDesafio.Text = "Qual o planeta mais próximo do Sol?";
                    lblRespostaUm.Text = "Mercúrio";
                    lblRespostaDois.Text = "Marte";
                }

                lblRespostaUm.Visible = true;
                lblRespostaDois.Visible = true;
            }
            else //se errar a resposta
            {
                this.Close();
            }

        }

        private void lblRespostaUm_Click(object sender, EventArgs e)
        {
            if (numeroAleatorio == 0 ||numeroAleatorio == 3)
                acertouResposta(true);
            else
                acertouResposta(false);
        }

        private void lblRespostaDois_Click(object sender, EventArgs e)
        {
            if (numeroAleatorio == 1 || numeroAleatorio == 2)
                acertouResposta(true);
            else
                acertouResposta(false);
        }

        private void acertouResposta(bool acertou)
        {
            if (acertou == true)
            {
                lblDesafio.Text = "Parabéns! Você Acertou!!! Pode Continuar.";
                pibVilao.Visible = false;
                btnCima.Visible = true;
                btnDir.Visible = true;
                btnEsq.Visible = true;
                lblRespostaUm.Visible = false;
                lblRespostaDois.Visible = false;
            }
            else
            {
                lblDesafio.Text = "Você Errou! GAME OVER";
                pibVilao.Width = 632;
                pibVilao.Height = 541;
                errou = true;
                lblRespostaUm.Visible = false;
                lblRespostaDois.Visible = false;
                btnContinuar.Show();
            }
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            this.Close();
            SeisForm seisForm = new SeisForm();
            seisForm.Show();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            this.Close();
            QuatroForm quatroForm = new QuatroForm();
            quatroForm.Show();
        }

        private void btnEsq_Click(object sender, EventArgs e)
        {
            this.Close();
            UmForm umForm = new UmForm();
            umForm.Show();
        }
    }
}
