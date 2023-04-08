using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMS
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.transactionsTableAdapter.Fill(this.bankDataSet.transactions);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-TKEBI6AJ\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM trasactions";
                SqlCommand cmd = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-TKEBI6AJ\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM transactions where number='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
        private void Form7_Load(object sender, EventArgs e)
        {
          
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

