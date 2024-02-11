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
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Sortear número aleatório
            int numeroAleatorio;
            Random rdm = new Random();
            numeroAleatorio = rdm.Next(3);

            //Fechar a tela inicio
            this.Hide();

            //Abre a tela aleatória
            if (numeroAleatorio == 0)
            {
                CincoForm cincoForm = new CincoForm();
                cincoForm.Show();
                //cincoForm.Closed += (object s, EventArgs ev) => this.Show();
            }
            else if(numeroAleatorio == 1)
            {
                TresForm tresForm = new TresForm();
                tresForm.Show();
                //tresForm.Closed += (object s, EventArgs ev) => this.Show();
            }
            else if( numeroAleatorio == 2)
            {
                UmForm umForm = new UmForm();
                umForm.Show();
                //umForm.Closed += (object s, EventArgs ev) => this.Show();
            }
            else
            {
                SeisForm seisForm = new SeisForm();
                seisForm.Show();
                //seisForm.Closed += (object s, EventArgs ev) => this.Show();
            }            

        }
    }
}
