using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 obj1 = new Form3();
            obj1.ShowDialog();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 obj2 = new Form4();
            obj2.ShowDialog();
        }

        private void debitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form6 obj3 = new Form6();
            obj3.ShowDialog();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 obj4 = new Form7();
            obj4.ShowDialog();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 obj5 = new Form5();
            obj5.ShowDialog();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 obj6 = new Form8();
            obj6.ShowDialog();
        }
    }
}
