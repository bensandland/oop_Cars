using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cars
{
    class Employees
    {
        int ID;
        string name;
        float meetTime;
        Assignments assignment;

        public Employees(int iD, string name, float meetTime)
        {
            ID = iD;
            this.name = name;
            this.meetTime = meetTime;
        }
    }
}
