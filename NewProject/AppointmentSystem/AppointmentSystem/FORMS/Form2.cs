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
using AppointmentSystem.Repository;

namespace AppointmentSystem
{
    public partial class Form2 : Form
    {

        Class1 class1;
        public Form2()
        {
            InitializeComponent();
            Class1 class1 = new Class1();

        }
        public void loadgrid()
        {
            Class1 class1 = new Class1();
            grid1.DataSource = class1.combinedViews1();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                using (DBAppointmentEntities1 db = new DBAppointmentEntities1())
                {
                    if (String.IsNullOrEmpty(txtFName.Text))
                    {
                        errorProvider1.SetError(txtFName, "Empty Field");
                        return;
                    }
                    if (String.IsNullOrEmpty(txtPhone.Text))
                    {
                        errorProvider1.SetError(txtPhone, "Empty Field");
                        return;
                    }
                    if (String.IsNullOrEmpty(txtGender.Text))
                    {
                        errorProvider1.SetError(txtGender, "Empty Field");
                        return;
                    }

                    Doctors tbl_Patients = new Doctors();

                    tbl_Patients.FName = txtFName.Text;
                    tbl_Patients.LName = txtLName.Text;


                    tbl_Patients.Phone = Convert.ToInt32(txtPhone.Text);

                    tbl_Patients.Gender = txtGender.Text;

                    db.Doctors.Add(tbl_Patients);
                    db.SaveChanges();

                    txtFName.Clear();
                    txtLName.Clear();
                    txtGender.Clear();
                    txtPhone.Clear();
                    MessageBox.Show("ACCEPTED!");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
