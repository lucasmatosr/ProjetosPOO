using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormVermelho : Form
    {
        public FormVermelho()
        {
            InitializeComponent();
        }

        private void formAzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAzul frm = new FormAzul();
            this.Close();
            frm.ShowDialog();
        }

        private void ExibirFormAmarelo_Click(object sender, EventArgs e)
        {
            FormAmarelo frm = new FormAmarelo();
            this.Close();
            frm.ShowDialog();
        }

        private void ExibirFormVermelho_Click(object sender, EventArgs e)
        {
            FormVermelho frm = new FormVermelho();
            this.Close();
            frm.ShowDialog();
        }
    }
}
