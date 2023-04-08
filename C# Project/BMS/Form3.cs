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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


 
            private void button1_Click(object sender, EventArgs e)
            {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TKEBI6AJ\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            try
            {
                string str = "INSERT INTO users(name,username,password,mobile_number,address,email,gender,age,occupation,annual_income) VALUES('" + textBox2.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox10.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from users ;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("User Account Details Inserted Successfully.. Your Account Number is " + dr.GetInt32(0) + ".");
                    this.Hide();

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "--Select--";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
        }
    }
    }

