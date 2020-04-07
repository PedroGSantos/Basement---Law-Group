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
    public partial class frm_consulta : Form
    {
        public frm_consulta()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frm_inicioo novo = new frm_inicioo();
            novo.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query;
            SqlConnection conn = new SqlConnection("Data Source=DJALMA\\SQLEXPRESS;Initial Catalog=Basement;User ID=sa;Password=123456");
          
            SqlDataAdapter da;
            query = "Select * From Dados";
            conn.Open();
            da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvdados.DataSource = dt;
            conn.Close();

           
                SqlDataAdapter du;
                query = "Select * From DireitoComercial";
                conn.Open();
                du = new SqlDataAdapter(query, conn);
                DataTable dp = new DataTable();
                du.Fill(dp);
                dgvco.DataSource = dp;
                conn.Close();
         
                SqlDataAdapter di;
                query = "Select * From DireitoCivil";
                conn.Open();
                di = new SqlDataAdapter(query, conn);
                DataTable dw = new DataTable();
                di.Fill(dw);
                dgvci.DataSource = dw;
                conn.Close();
         
           
                SqlDataAdapter dqq;
                query = "Select * From DireitoPenal";
                conn.Open();
                dqq = new SqlDataAdapter(query, conn);
                DataTable dx = new DataTable();
                dqq.Fill(dx);
                dgvpen.DataSource = dx;
                conn.Close();
           

            SqlDataAdapter dc;
            query = "Select * From Vertentes";
            conn.Open();
            dc = new SqlDataAdapter(query, conn);
            DataTable dm = new DataTable();
            dc.Fill(dm);
            dgvv.DataSource = dm;
            conn.Close();

            SqlDataAdapter dd;
            query = "Select * From Termos";
            conn.Open();
            dd = new SqlDataAdapter(query, conn);
            DataTable ds = new DataTable();
            dd.Fill(ds);
            dgvt.DataSource = ds;
            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            dgvt.Rows.RemoveAt(dgvt.CurrentRow.Index);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvco.Rows.RemoveAt(dgvco.CurrentRow.Index);
        }

        private void dgvpen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvpen.Rows.RemoveAt(dgvpen.CurrentRow.Index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvci.Rows.RemoveAt(dgvci.CurrentRow.Index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvv.Rows.RemoveAt(dgvv.CurrentRow.Index);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvdados.Rows.RemoveAt(dgvdados.CurrentRow.Index);
        }
    }
}
