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
    public partial class QuatroForm : Form
    {
        public QuatroForm()
        {
            InitializeComponent();
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            this.Close();
            TresForm tresForm = new TresForm();
            tresForm.Show();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            this.Close();
            VitoriaForm vitoriaForm = new VitoriaForm();
            vitoriaForm.Show();
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            this.Close();
            DoisForm doisForm = new DoisForm();
            doisForm.Show();
        }

        private void btnEsq_Click(object sender, EventArgs e)
        {
            this.Close();
            CincoForm cincoForm = new CincoForm();
            cincoForm.Show();
        }
    }
}
