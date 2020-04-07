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
    public partial class frm_vertentes : Form
    {
        public frm_vertentes()
        {
            InitializeComponent();
        }

     
        

        private void btn_continuar2_Click(object sender, EventArgs e)
        {

            
            if (cbm_vertentes.Text == "Direito Comercial")
            {
              
                Direito_Comercial novo = new Direito_Comercial();
                novo.Show();
                Hide();
            }

            if (cbm_vertentes.Text == "Direito Civil")
            {

                
                DireitoCivil novo = new DireitoCivil();
                novo.Show();
                Hide();
            }

            if (cbm_vertentes.Text == "Direito Penal")
            {
                Direito_Penal novo = new Direito_Penal();
                novo.Show();
                Hide();
               
                
              
            
                

            }
            if (cbm_vertentes.Text == "")
            {
                erro novo = new erro();
                novo.Show();
            }
            SqlConnection conn = new SqlConnection("Data Source=L21105\\SQLEXPRESS;Initial Catalog=Basement;User ID=sa;Password=123456");
            string sql = "INSERT INTO Vertentes(Vertente) VALUES(@Vertente)";
            //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.Add(new SqlParameter("@Vertente", this.cbm_vertentes.Text));
          





            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();



        }

        private void frm_vertentes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            frm_dadospessoais novo = new frm_dadospessoais ();
            novo.Show();
            Hide();
        }

        public void cbm_vertentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
