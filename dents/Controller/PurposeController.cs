using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dents.Controller
{
    class PurposeController
    {
        Model.PurposeModel purpose = new Model.PurposeModel();

        public DataTable getAllPurpose()
        {
            try
            {
                return purpose.getAllPurpose();
            }
            catch
            {
                throw;
            }
        }

        public Boolean deletePurpose(int id)
        {
            try
            {
                return purpose.deletePurpose(id);
            }
            catch
            {
                return false;
            }
        }

        public Boolean updatePurpose(string id, string procedure_name, string procedure_amount)
        {
            try
            {
                return purpose.updatePurpose(id, procedure_name, procedure_amount);
            }
            catch
            {
                return false;
            }
        }

        public Int32 addPurpose(string procedure_name, string procedure_amount)
        {
            try
            {
                return purpose.addPurpose(procedure_name, procedure_amount);
            }
            catch
            {
                throw;
            }
        }
    }
}
