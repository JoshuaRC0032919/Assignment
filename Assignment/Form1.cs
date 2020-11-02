using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
         {
            //use try catch from textboxes
            try
            {
                double lengh = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                // finds volume
                double volume = lengh * width * height;

                label1.Text = "volume = " + volume;
            }
            //use catch to ouput error message
            catch
            {
                MessageBox.Show("Error on input. ");
            }

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
