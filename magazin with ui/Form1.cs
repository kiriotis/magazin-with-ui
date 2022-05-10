using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;


namespace magazin_with_ui
{
    public partial class Form1 : Form
    {
        public string name;
        public string price;
        public string file;
        public int x;
        public int id_counter;
        public int id_counter2;
        public string[][] arr1 = new string[1000][];




        public Form1()
        {
            id_counter = new json_provaider().provide();
            InitializeComponent();



            radioButton1.Checked = true;


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
            listBox1.Items.Clear();
            items search = new items();
            int i1=0;

            if (radioButton1.Checked)
            {
                x = 1;

            }
            else if (radioButton2.Checked)
            {
                x = 2;
            }
            else if (radioButton3.Checked)
            {
                x = 3;
            }

            search.item_search(textBox1.Text, x, id_counter,out arr1,out id_counter2);
            do
            {
                listBox1.Items.Add(arr1[i1][0]);
                i1++;
            }
            while (i1< id_counter2);
            //pictureBox1.ImageLocation = file;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }  

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = arr1[listBox1.SelectedIndex][2];
            label2.Text = arr1[listBox1.SelectedIndex][1];
        }
    }
}
