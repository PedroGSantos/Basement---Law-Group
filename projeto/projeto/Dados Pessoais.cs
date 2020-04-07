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
    public partial class frm_dadospessoais : Form
    {
        public frm_dadospessoais()
        {
            InitializeComponent();
           

        }
      
       
    


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
           

           
           
            if (  txtnome.Text == "" || MtxtCPF.Text == "" || MtxtRG.Text == "" || MtxtTelefone.Text == "" || cbocidade.Text == "" || MtxtCNPJ.Text == "" || MtxtData.Text == "" || rbomasc.Checked == false && rbofem.Checked == false)
            {
                erro novo = new erro();
                novo.Show();
            }
            else
            {
                if (rbofem.Checked == true)
                {
                    rbomasc.Text = "Feminino";
                }
                if (rbomasc.Checked == true)
                {
                    rbomasc.Text = "Masculino";
                }
                SqlConnection conn = new SqlConnection("Data Source=DJALMA\\SQLEXPRESS;Initial Catalog=Basement;User ID=sa;Password=123456");
                string sql = "INSERT INTO Dados(Nome, CPF, RG, Telefone, Cidade, Profissão, CNPJ, Data, Sexo) VALUES(@Nome, @CPF, @RG, @Telefone, @Cidade, @Profissão, @CNPJ, @Data, @Sexo)";

                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@Nome", this.txtnome.Text));
                comando.Parameters.Add(new SqlParameter("@CPF", this.MtxtCPF.Text));
                comando.Parameters.Add(new SqlParameter("@RG", this.MtxtRG.Text));
                comando.Parameters.Add(new SqlParameter("@Telefone", this.MtxtTelefone.Text));
                comando.Parameters.Add(new SqlParameter("@Cidade", this.cbocidade.Text));
                comando.Parameters.Add(new SqlParameter("@Profissão", this.txtprofissão.Text));
                comando.Parameters.Add(new SqlParameter("@CNPJ", this.MtxtCNPJ.Text));
                comando.Parameters.Add(new SqlParameter("@Data", this.MtxtData.Text));
                comando.Parameters.Add(new SqlParameter("@Sexo", this.rbomasc.Text));
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
                frm_vertentes novo = new frm_vertentes();
                    novo.Show();
                    Hide();

                
            }
        }

        private void frm_dadospessoais_Load(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
        
            
           Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtprofissão_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MtxtData.Text = "";
            MtxtCPF.Text = "";
            MtxtRG.Text = "";
            MtxtTelefone.Text = "";
            MtxtCNPJ.Text = "";
            txtnome.Text = "";
            txtprofissão.Text = "";
            cbocidade.Text = "";
            rbofem.Checked = false;
            rbomasc.Checked = false;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
