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

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //use try catch from textboxes
            try

            {
                double lengh = double.Parse(textBox1.Text);
                double height = double.Parse(textBox2.Text);
                double width = double.Parse(textBox3.Text);
                // finds surface area
                double surfacearea = 2.0 * (lengh * width + width * height + lengh * height);

                label5.Text = "surfacearea = " + surfacearea;
            }
            //use catch to ouput error message
            catch
            {
                MessageBox.Show("Error on input. ");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
            
        {
            //use try catch from textboxes
            try
            {
                double radius = double.Parse(textBox4.Text);
                double volume = 4 * radius * radius * radius * 3.14159 / 3;
                label7.Text = "volume = " + volume;
            }
            //use catch to ouput error message
            catch
            {
                MessageBox.Show("Error on input. ");
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            //use try catch from textboxes
            try
            {
                double radius = double.Parse(textBox4.Text);
                double surfacearea = 4 * 3.145 * radius * radius;
                label8.Text = "surfacearea = " + surfacearea;
            }
            //use catch to ouput error message
            catch
            {
                MessageBox.Show("Error on input. ");
            }
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            {

            }
        }
    }
        
        
        
         
}
