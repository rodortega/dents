using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dents.Controller
{
    public class AppointmentController
    {
        Model.AppointmentModel appointment = new Model.AppointmentModel();

        public DataTable GetAllAppointments()
        {
            try
            {            
                return appointment.getAllAppointments();
            }
            catch
            {
                throw;
            }
        }

        public DataTable getAppointmentByPatientId(int patient_id)
        {
            try
            {
                return appointment.getAppointmentByPatientId(patient_id);
            }
            catch
            {
                throw;
            }
        }

        public Boolean updateAppointment(Int32 id)
        {
            try
            {
                return appointment.updateAppointment(id);        
            }
            catch
            {
                return false;
            }
        }

        public Boolean addAppointment(string title, string description, string schedule, string patient_id, string status)
        {
            try
            {
                return appointment.addAppointment(title,description,schedule,patient_id,status);
            }
            catch
            {
                return false;
            }
        }
    }
}
