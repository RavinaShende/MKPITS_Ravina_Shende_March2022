using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg23_1_array_sum_of_5no_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //create an array of 5 elements 
        int[] num = new int[5];
        int i = 0;
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(i < 5)
            {
                num[i] = Convert.ToInt32(textBox1.Text);
                sum = sum + num[i];
                i++;
                textBox1.Clear();
                textBox1.Focus();
                if(i==5)
                {
                    label2.Text = "Sum of 5 no. : " + sum;
                }
            }
        }
    }
}
