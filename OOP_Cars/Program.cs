using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Cars
{
    public class Program
    {
        List<int> empid = new List<int> { };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public void Main()
        {
            Employees emp1 = new Employees(1, "Kurt", 16.45);

            
            empid.Add(1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public int EmpIDLengh()
        {
            return empid.Count;
        }
    }
}
