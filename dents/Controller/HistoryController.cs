using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dents.Controller
{
    public class HistoryController
    {
        Model.HistoryModel history = new Model.HistoryModel();

        public Boolean addHistory(string patient_id, string procedure_name, string teeth_number, string amount, string datetime_create)
        {
            try
            {
                return history.AddHistory(patient_id, procedure_name, teeth_number, amount, datetime_create);
            }
            catch
            {
                throw;
            }
        }

        public DataTable getHistoryByPatientId(int patient_id)
        {
            try
            {
                return history.getHistoryByPatientId(patient_id);
            }
            catch
            {
                throw;
            }
        }
    }
}
