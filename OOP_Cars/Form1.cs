using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Cars
{
    public partial class Form1 : Form
    {        
        List<Employees> employees = new List<Employees>();
        public Form1()
        {
            InitializeComponent();

            employees.Add(new Employees(1, "Kurt", 16.45));
            employees.Add(new Employees(2, "Jens", 15.15));
            employees.Add(new Employees(3, "Jacob", 12.12));

            foreach (Employees employee in employees)
            {
                comboBox1.Items.Add(employee.GetName());
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string valg = comboBox1.SelectedItem.ToString();
            MessageBox.Show(valg + " " + (comboBox1.SelectedIndex + 1));
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
