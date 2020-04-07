using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            if (txt_nomeempresa.Text == "" || cbo_sociedade.Text == "" || cbo_orçamentoc.Text == "" || rbosim.Checked == false && rbonão.Checked == false)
            {
                erro novo = new erro();
                novo.Show();
            }
            else {
                if (rbosim.Checked == true)
                {
                    rbosim.Text = "Sim";
                }
                if (rbonão.Checked == true)
                {
                    rbosim.Text = "Sim";
                }
                if (chbsim.Checked == true)
                {
                    chbsim.Text = "Sim";
                }
                if (chbsim.Checked == false)
                {
                    chbsim.Text = " ";
                }
                if (chbsim2.Checked == true)
                {
                    chbsim2.Text = "Sim";
                }
                if (chbsim2.Checked == false)
                {
                    chbsim2.Text = " ";
                }
                SqlConnection conn = new SqlConnection("Data Source=L21105\\SQLEXPRESS;Initial Catalog=Basement;User ID=sa;Password=123456");
                string sql = "INSERT INTO DireitoComercial(Empresa, Multinacional, Conflitos_com_outras_empresas, Conflitos_com_o_governo, Sociedade, Orçamento) VALUES(@Empresa, @Multinacional, @Conflitoem, @Conflitogo, @Sociedade, @Orçamento)";

                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@Empresa", this.txt_nomeempresa.Text));
                comando.Parameters.Add(new SqlParameter("@Multinacional", this.rbosim.Text));
                comando.Parameters.Add(new SqlParameter("@Conflitoem", this.chbsim.Text));
                comando.Parameters.Add(new SqlParameter("@Conflitogo", this.chbsim2.Text));
                comando.Parameters.Add(new SqlParameter("@Sociedade", this.cbo_sociedade.Text));
                comando.Parameters.Add(new SqlParameter("@Orçamento", this.cbo_orçamentoc.Text));
                
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
                frm_termos novo = new frm_termos();
                novo.Show();
                Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_vertentes novo = new frm_vertentes();
            novo.Show();
            Hide();
        }

        private void txt_nomeempresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rbosim.Checked = false;
            rbonão.Checked = false;
            txt_nomeempresa.Text = "";
            cbo_orçamentoc.Text = "";
            cbo_sociedade.Text = "";
            chbsim.Checked = false;
            chbsim2.Checked = false;



            
        }
    }
}
