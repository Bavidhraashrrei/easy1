using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePromotion
{
   public class employeedetails
    {
        List<string> emp_name = new List<string>();
        string name;
        public void Add_employee_name()
        {
            do
            {
                name = Console.ReadLine();
                emp_name.Add(name);
            } while (!string.IsNullOrEmpty(name));
        }
     }
}
