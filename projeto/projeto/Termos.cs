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
    public partial class frm_termos : Form
    {
        public frm_termos()
        {
            InitializeComponent();
        }

        

     
       
        private void button2_Click(object sender, EventArgs e)
        {
           


        }
       
        private void txtrelato_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
           
            if (txtrelato.Text == "" || chbtermos.Checked == false)
            {
                erro novo = new erro();
                novo.Show();
            }
            else
            {
                if (chbtermos.Checked == true)
                {
                    chbtermos.Text = "Aceito";
                }

                SqlConnection conn = new SqlConnection("Data Source=L21105\\SQLEXPRESS;Initial Catalog=Basement;User ID=sa;Password=123456");
                string sql = "INSERT INTO Termos(Relato, Termos_de_Contrato) VALUES(@Relato, @termos)";

                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@relato", this.txtrelato.Text));
                comando.Parameters.Add(new SqlParameter("@termos", this.chbtermos.Text));
           

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
                chbtermos.Text = "Li e aceito os termos de contrato";
                MessageBox.Show("Você foi cadastrado, obrigado pela preferência");
               

            }
      
        }
      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frm_inicioo a = new frm_inicioo();
            a.Show();
            Hide();
        }
    }
    }

