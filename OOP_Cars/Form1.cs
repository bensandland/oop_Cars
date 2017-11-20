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
        public Calender cal = new Calender();
        BindingSource employeeBinding = new BindingSource();
        MedarbejderForm maf;

        public string selectedName;

        public Form1()
        {
            InitializeComponent();
            
            SetupData();

            employeeBinding.DataSource = cal.Employees;
            EmployeeListBox.DataSource = employeeBinding;

            EmployeeListBox.DisplayMember = "Display";
            EmployeeListBox.ValueMember = "Display";
        }


        private void SetupData()
        {
            cal.Employees.Add(new Employee { ID = 1, name = "Lars", meetTime = 08.50 });
            cal.Employees.Add(new Employee { ID = 2, name = "Ulrik", meetTime = 08.50 });
            cal.Employees.Add(new Employee { ID = 3, name = "Kevin", meetTime = 08.50 });

        }

        public void selectEmployee_Click(object sender, EventArgs e)
        {
            Employee selectedItem = (Employee)EmployeeListBox.SelectedItem;

            selectedName = (string)selectedItem.name;
            MessageBox.Show(selectedName);
            maf = new MedarbejderForm();

            maf.Show();
            this.Hide();

        }
    }
}
