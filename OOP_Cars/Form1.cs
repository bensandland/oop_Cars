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
        List<int> empid = new List<int> { };
        public Form1()
        {
            InitializeComponent();

            empid.Add(1);
            empid.Add(2);
            empid.Add(3);

            int id = empid.Count;
            for (int i = 1; i < id + 1; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
