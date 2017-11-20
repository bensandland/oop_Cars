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
    public partial class MedarbejderForm : Form
    {
        Form1 frm1;

        public MedarbejderForm()
        {
            InitializeComponent();

            MessageBox.Show(frm1.selectedName);

            //EmployeeName.Text = ;

        }
    }
}
