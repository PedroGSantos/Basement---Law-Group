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
    public partial class Direito_Comercial : Form
    {
        public Direito_Comercial()
        {
            InitializeComponent();
        }

        private void Direito_Comercial_Load(object sender, EventArgs e)
        {

        }

        private void btn_continuar2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_vertentes novo = new frm_vertentes();
            novo.Show();
            Hide();
        }
    }
}
