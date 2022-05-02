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
        public int x ;
        public int id_counter;
      
        
       


        public Form1()
        {
            id_counter = new json_provaider().provide();
            InitializeComponent();


            
            radioButton1.Checked=true;
          
           
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
            
            search.item_search(textBox1.Text, x, id_counter, out name, out price, out file);

            label2.Text = name;
            label3.Text = price;
            pictureBox1.ImageLocation = file;
            
            // search.item_all(textBox1.Text, x, out name, out price, out file);







        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
