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
    public partial class Direito_Penal : Form
    {
        public Direito_Penal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_vertentes novo = new frm_vertentes();
            novo.Show();
            Hide();
        }

        private void btncontinuar2_Click(object sender, EventArgs e)
        {
            

            if (cbo_orçamento.Text == "" || rbosim.Checked == false && rbonão.Checked == false && rbo3.Checked == false && rbo2.Checked == false && rbo4.Checked == false && rbo1.Checked == false && rbonão2.Checked == false && rbosonegação.Checked == false && rbohomiquali.Checked == false && rbocorrup.Checked == false && rbohomicul.Checked == false && rbofurto.Checked == false && rbomais.Checked == false && rboum.Checked == false && rbonenhum.Checked == false && rbonãocometi.Checked == false )
            {
                erro novo = new erro();
                novo.Show();
            }
            else {
                if (rbosim.Checked == true)
                {
                    rbosim.Text = "Limpa";
                }
                if (rbonão.Checked == true)
                {
                    rbosim.Text = "Suja";
                }

                if (rbonão2.Checked == true)
                {
                    rbonão2.Text = "Não";
                }
                if (rbosonegação.Checked == true)
                {
                    rbonão2.Text = "Sonegação de imposto";
                }
                if (rbohomiquali.Checked == true)
                {
                    rbonão2.Text = "Homicídio qualificado";
                }
                if (rbohomicul.Checked == true)
                {
                    rbonão2.Text = "Homicídio Culposo";
                }
                if (rbofurto.Checked == true)
                {
                    rbonão2.Text = "Furto";
                }

                if (rbo1.Checked == true)
                {
                    rbo1.Text = "1º instância";
                }
                if (rbo2.Checked == true)
                {
                    rbo1.Text = "2º instância";
                }
                if (rbo3.Checked == true)
                {
                    rbo1.Text = "3º instância";
                }
                if (rbo4.Checked == true)
                {
                    rbo1.Text = "4º instância";
                }
                if (rbonãocometi.Checked == true)
                {
                    rbonãocometi.Text = "Não cometi nenhum crime";
                }

                if (rbonãocometi.Checked == true)
                {
                    rbonãocometi.Text = "Não cometi nenhum crime";
                }
                if (rbonenhum.Checked == true)
                {
                    rbonãocometi.Text = "Nenhum";
                }
                if (rboum.Checked == true)
                {
                    rbonãocometi.Text = "Um";
                }
                if (rbomais.Checked == true)
                {
                    rbonãocometi.Text = "Mais de um";
                }
                if (chbsim.Checked == true)
                {
                    chbsim.Text = "Sim";
                }
                if (chbsim.Checked == false)
                {
                    chbsim.Text = "";
                }
                if (chbsim2.Checked == true)
                {
                    chbsim2.Text = "Sim";
                }
                if (chbsim2.Checked == false)
                {
                    chbsim2.Text = "";
                }


                SqlConnection conn = new SqlConnection("Data Source=L21105\\SQLEXPRESS;Initial Catalog=Basement;User ID=sa;Password=123456");
                string sql = "INSERT INTO DireitoPenal(Ficha, Conflito_com_o_Governo, Cometeu_Algum_Crime, Julgamento, Impedido_De_Viajar, Orçamento, Cumplices) VALUES(@Ficha, @Conflito, @Crime, @Julgamento, @Viajar, @Orçamento, @Cumplices)";

                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@Ficha", this.rbosim.Text));
                comando.Parameters.Add(new SqlParameter("@Conflito", this.chbsim.Text));
                comando.Parameters.Add(new SqlParameter("@Crime", this.rbonão2.Text));
                comando.Parameters.Add(new SqlParameter("@Julgamento", this.rbo1.Text));
                comando.Parameters.Add(new SqlParameter("@Viajar", this.chbsim2.Text));
                comando.Parameters.Add(new SqlParameter("@Orçamento", this.cbo_orçamento.Text));
                comando.Parameters.Add(new SqlParameter("@Cumplices", this.rbonãocometi.Text));
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
                frm_termos novo = new frm_termos();
                novo.Show();
                Hide();
            }
        }

        private void Direito_Penal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rbohomicul.Checked = false;
            rbofurto.Checked = false;
            rbocorrup.Checked = false;
            rbohomiquali.Checked = false;
            rbosonegação.Checked = false;
            rbonão.Checked = false;

            rbosim.Checked = false;
            rbonão.Checked = false;

            rbo1.Checked = false;
            rbo2.Checked = false;
            rbo3.Checked = false;
            rbo4.Checked = false;

            rbonãocometi.Checked = false;
            rbonenhum.Checked = false;
            rboum.Checked = false;
            rbomais.Checked = false;

            chbsim.Checked = false;
            chbsim2.Checked = false;

            cbo_orçamento.Text = "";


            
        }
    }
}
