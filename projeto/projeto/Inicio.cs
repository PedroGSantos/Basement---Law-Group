using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class frm_inicioo : Form
    {
        public frm_inicioo()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Senha novo = new frm_Senha();
            novo.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            novo.MdiParent = this;
            novo.Show();
            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dadospessoais novo = new frm_dadospessoais();
            novo.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            novo.MdiParent = this;
            novo.Show();

        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Contato novo = new Frm_Contato();
            novo.WindowState = System.Windows.Forms.FormWindowState.Normal;
            novo.MdiParent = this;
            novo.Show();
           
        }

        private void objetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Objetivo novo = new Frm_Objetivo();
            novo.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            novo.MdiParent = this;
            novo.Show();
         
            

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void saiurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Close();
        }
    }
}
