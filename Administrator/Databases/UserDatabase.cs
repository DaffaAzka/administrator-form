using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.Databases
{
    public class UserDatabase
    {
        public static string myConnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

    }
}
