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
    public partial class Form1 : Form
    {
        DBAppointmentEntities1 db;
        public Form1()
        {
            InitializeComponent();
            db = new DBAppointmentEntities1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loadMonth();
            //loadDay();
            //loadTime();
        }
        //private void loadMonth()
        //{
        //    using (db = new DBSysAppointmentEntities1())
        //    {
        //        var Month = db.Schedules.ToList();

        //        cbMonth.ValueMember = "id";
        //        cbMonth.DisplayMember = "Month";
        //        cbMonth.DataSource = Month;
        //    }
        //}
        //private void loadDay()
        //{
        //    using (db = new DBSysAppointmentEntities1())
        //    {
        //        var Day = db.Schedules.ToList();

        //        cbMonth.ValueMember = "id";
        //        cbMonth.DisplayMember = "Day";
        //        cbMonth.DataSource = Day;
        //    }
        //}
        //private void loadTime()
        //{
        //    using (db = new DBSysAppointmentEntities1())
        //    {
        //        var Time = db.Schedules.ToList();

        //        cbMonth.ValueMember = "id";
        //        cbMonth.DisplayMember = "Time";
        //        cbMonth.DataSource = Time;
        //    }
        //}


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                Patient tbl_Patients = new Patient();

                tbl_Patients.FName = txtFName.Text;
                tbl_Patients.LName = txtLName.Text;

               
                tbl_Patients.PNumber = Convert.ToInt32(txtPhone.Text);

                tbl_Patients.Gender = txtGender.Text;
                tbl_Patients.Date = dateTimePicker1.Value; 

                db.Patient.Add(tbl_Patients);
                db.SaveChanges();

                txtFName.Clear();
                txtLName.Clear();
                txtGender.Clear();
                txtPhone.Clear();
                MessageBox.Show("Registered!");
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

        private void dOCTORSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }

}