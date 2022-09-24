using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg23_4_user_define_function_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //crate 2d array 
        string[,] album = new string[2, 2];
        StringBuilder sb=new StringBuilder();
        public void Display()
        {
            album[0, 0] = textBox1.Text;
            album[0, 1] = textBox2.Text;
            album[1, 0] = textBox3.Text;
            album[1, 1] = textBox4.Text;
            sb.Append("Album name " + album[0, 0] + ": Singer name " + album[0, 1] + "\n");
            sb.Append("Album name " + album[1, 0] + ": Singer name " + album[1, 1] + "\n");
            label5.Text=sb.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
