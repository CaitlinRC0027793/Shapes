using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(textBox2.Text);
                double ans = 4.0 / 3.0 * Math.PI * r * r * r;

                label2.Text = "volume = " + ans.ToString("0.00");
            }

            catch
            {
                label2.Text = "volume = ";
            }           
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
