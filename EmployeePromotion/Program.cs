using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;


namespace EmployeePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            employeedetails em = new employeedetails();
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion");
            em.Add_employee_name();
        }
    }
}
