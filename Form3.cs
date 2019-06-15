using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic
{
    public partial class Form3 : Form
    {
        Form1 main;
        public Form3(Form1 f)
        {
            InitializeComponent();
            main = f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
