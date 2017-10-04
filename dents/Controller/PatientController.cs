using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dents.Controller
{
    public class PatientController
    {

        Model.PatientModel patient = new Model.PatientModel();

        public DataTable getAllPatients()
        {
            return patient.getAllPatients();
        }

        public DataTable getPatientById(int id)
        {
            return patient.getPatientById(id);
        }

        public Int32 addPatient(string firstname, string lastname, string phone, string address, string birthday, string gender, string status)
        {
            try
            {
                return patient.addPatient(firstname, lastname, phone, address, birthday, gender, status);
            }
            catch
            {
                throw;
            }
        }

        public Boolean updatePatient(string patient_id, string firstname, string lastname, string phone, string address, string birthday, string gender, string status)
        {
            try
            {
                return patient.updatePatient(patient_id, firstname, lastname, phone, address, birthday, gender, status);
            }
            catch
            {
                return false;
            }
        }
    }
}
