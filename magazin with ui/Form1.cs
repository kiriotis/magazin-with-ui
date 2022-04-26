using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magazin_with_ui
{
    public partial class Form1 : Form
    {
        public string name;
        public string price;
        public string file;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            items search = new items();
            search.item_all(textBox1.Text,out name,out price,out file);
            label2.Text = name;
            label3.Text = price;
            //label4.Text = file;
            //pictureBox1.Image = Image.FromFile(file);
            //pictureBox1.ImageLocation = file;
            pictureBox1.ImageLocation= file;
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
