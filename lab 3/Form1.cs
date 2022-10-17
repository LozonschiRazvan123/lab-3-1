using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSolution_Click(object sender, EventArgs e)
        {
            double a, b, result;
            try
            {
                a = Double.Parse(textBoxA.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("'A' should be a double number");
                return;
            }
            try
            {
                b = Double.Parse(textBoxB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("'B' should be a double number");
                return;
            }
            if (a == 0)
                if (b == 0)
                    MessageBox.Show("There is an infinitive solution");
                else
                    MessageBox.Show("No solution");
            else
            {
                result = -b / a;
                MessageBox.Show("Result" + result.ToString());
            }
        }
    }
}
