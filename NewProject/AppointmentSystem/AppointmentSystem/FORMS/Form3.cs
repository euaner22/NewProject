using AppointmentSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppointmentSystem.Model;


namespace AppointmentSystem
{
    public partial class Form3 : Form
    {
        Class1 Class1;
        public Form3()
        {
            InitializeComponent();
        }
        public void loadgrid()
        {
            Class1 class1 = new Class1();
            grid2.DataSource = class1.combinedViews2();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
