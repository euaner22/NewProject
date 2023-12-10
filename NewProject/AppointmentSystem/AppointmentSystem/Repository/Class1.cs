using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointmentSystem.Model;
using AppointmentSystem.utils;


namespace AppointmentSystem.Repository
{
  
    internal class Class1
    {
        DBAppointmentEntities1 db;

        public Class1()
        {
            db = new DBAppointmentEntities1();
        }

        public List<Patient> combinedViews1()
        {
            using (db = new DBAppointmentEntities1())
            {
                return db.Patient.ToList();
            }
        }
        public List<view_admin> combinedViews2()
        {
            using (db = new DBAppointmentEntities1())
            {
                return db.view_admin.ToList();
            }
        }
        public ErrorCode DeletePsitsUsingStoredProf(int pId, ref String szResponse)
        {
            using (db = new DBAppointmentEntities1())
            {
                try
                {
                    //db.DeleteAppointment(pId);
                    szResponse = "Deleted";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }

    }
   
}
