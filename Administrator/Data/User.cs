using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Administrator.Data
{
    public class User
    {
        int ID {  get; set; }
        string EmployeeID {  get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Fullname { get; set; }
        string Status { get; set; }
        string Role { get; set; }
        string DateEntry { get; set; }
        string DateOut { get; set; }

    }
}
