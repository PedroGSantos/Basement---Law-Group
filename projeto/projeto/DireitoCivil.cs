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
    public partial class DireitoCivil : Form
    {
        public DireitoCivil()
        {
            InitializeComponent();
        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbo_orçamentocivil.Text == "" || rbosim.Checked == false && rbonão.Checked == false || rbosim2.Checked == false && rbonão2.Checked == false && rbopai.Checked == false && rbomãe.Checked == false && rbomar.Checked == false && rboirmão.Checked == false && rboprimo.Checked == false && rboutro.Checked == false && rboutro.Checked == false && rbonão3.Checked == false && rboprimo.Checked == false && rbosolteiro.Checked == false && rbocasado.Checked == false && rbounião.Checked == false && rbodivorciado.Checked == false && rboviúvo.Checked == false && rbosim3.Checked == false && rbonão4.Checked == false && rbosim4.Checked == false)
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
                    rbosim.Text = "Não";
                }
                if (rbosim2.Checked == true)
                {
                    rbosim2.Text = "Sim";
                }
                if (rbonão2.Checked == true)
                {
                    rbosim2.Text = "Sim";
                }
                if (rbopai.Checked == true)
                {
                    rboprimo.Text = "Pai";
                }
                if (rboprimo.Checked == true)
                {
                    rboprimo.Text = "Primo";
                }
                if (rbomãe.Checked == true)
                {
                    rboprimo.Text = "Mãe";
                }
                if (rbomar.Checked == true)
                {
                    rboprimo.Text = "Marido/Esposa";
                }
                if (rboirmão.Checked == true)
                {
                    rboprimo.Text = "Irmão";
                }
                if (rboutro.Checked == true)
                {
                    rboprimo.Text = "Outro";
                }
                if (rbonão3.Checked == true)
                {
                    rboprimo.Text = "Não";
                }
                if (rbosolteiro.Checked == true)
                {
                    rbosolteiro.Text = "Solteiro";
                }
                if (rbounião.Checked == true)
                {
                    rbosolteiro.Text = "Em União Estável";
                }
                if (rboviúvo.Checked == true)
                {
                    rbosolteiro.Text = "Viúvo";
                }
                if (rbodivorciado.Checked == true)
                {
                    rbosolteiro.Text = "Divorciado";
                }
                if (rbocasado.Checked == true)
                {
                    rbocasado.Text = "Casado";
                }
                if (rbosim3.Checked == true)
                {
                    rbosim3.Text = "Sim, um";
                }
                if (rbosim4.Checked == true)
                {
                    rbosim3.Text = "Sim, mais de um";
                }
                if (rbonão4.Checked == true)
                {
                    rbosim3.Text = "Não";
                }
                SqlConnection conn = new SqlConnection("Data Source=L21105\\SQLEXPRESS;Initial Catalog=Basement;User ID=sa;Password=123456");
                string sql = "INSERT INTO DireitoCivil(Vai_Fazer_Um_Testamento, Ficha, Parente_Morto, Estado_Civil, Possui_Imovel, Orçamento) VALUES(@Testamento, @Ficha, @Parente, @Estado, @Possui, @Orçamento)";

                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@Testamento", this.rbosim.Text));
                comando.Parameters.Add(new SqlParameter("@Ficha", this.rbosim2.Text));
                comando.Parameters.Add(new SqlParameter("@Parente", this.rboprimo.Text));
                comando.Parameters.Add(new SqlParameter("@Estado", this.rbosolteiro.Text));
                comando.Parameters.Add(new SqlParameter("@Possui", this.rbosim3.Text));
                comando.Parameters.Add(new SqlParameter("@Orçamento", this.cbo_orçamentocivil.Text));
          
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
                frm_termos novo = new frm_termos();
                novo.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_vertentes novo = new frm_vertentes();
            novo.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            rbodivorciado.Checked = false;
            rbosolteiro.Checked = false;
            rbocasado.Checked = false;
            rbounião.Checked = false;
            rboviúvo.Checked = false;

            rboirmão.Checked = false;
            rbomar.Checked = false;
            rbopai.Checked = false;
            rbomãe.Checked = false;
            rboprimo.Checked = false;
            rboutro.Checked = false;
            rbonão3.Checked = false;

            rbosim.Checked = false;
            rbonão.Checked = false;

            rbonão2.Checked = false;
            rbosim2.Checked = false;

            rbosim3.Checked = false;
            rbosim4.Checked = false;
            rbonão4.Checked = false;

            cbo_orçamentocivil.Text = "";


        }
    }
}
