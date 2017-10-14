using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dents
{
    public class Connection
    {
        public static string credentials = System.Configuration.ConfigurationManager.ConnectionStrings["server"].ConnectionString;
    }
}
