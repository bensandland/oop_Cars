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
        
        List<Employees> employess;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedItem);
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
