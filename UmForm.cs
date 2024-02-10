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
    public partial class UmForm : Form
    {
        public UmForm()
        {
            InitializeComponent();
        }

        private void btnCimaSalaUm_Click(object sender, EventArgs e)
        {
            this.Close();
            DoisForm doisForm = new DoisForm();
            doisForm.Show();
        }

        private void btnDirSalaUm_Click(object sender, EventArgs e)
        {
            this.Close();
            DoisForm doisForm = new DoisForm();
            doisForm.Show();
        }

        private void btnEsqSalaUm_Click(object sender, EventArgs e)
        {
            this.Close();
            SeisForm seisForm = new SeisForm();
            seisForm.Show();
        }
    }
}
