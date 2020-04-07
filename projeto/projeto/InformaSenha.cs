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
    public partial class frm_Senha : Form
    {
        public frm_Senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsenha.Text == "embasamento")
            {
                
                frm_consulta novo = new frm_consulta();
                novo.Show();
                Hide();

            }
            else if (txtsenha.Text == "" || txtsenha.Text != "embasamento")
            {
                MB novo = new MB();
                novo.Show();
            }
          
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            txtsenha.PasswordChar = '*';

            txtsenha.MaxLength = 13;
        }
    }
}
