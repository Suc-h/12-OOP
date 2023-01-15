using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Produkt Ondrementy;
        private void Form1_Load(object sender, EventArgs e)
        {
            if((int)numericUpDown3.Value==1)
            {
                Ondrementy = new Produkt(1, textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value);
            }
            else
            {
                Ondrementy = new Produkt(0,textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value); ;
            }
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown3.Value == 1)
            {
                Ondrementy = new Produkt(1, textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value);
            }
            else
            {
                Ondrementy = new Produkt(0, textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value); ;
            }
            if(Ondrementy.Splnuje())
            {
                MessageBox.Show("Tento produkt nepřekročil minimální dobu trvanlivosti.");
            }
            else
            {
                MessageBox.Show("Tento produkt překročil minimální dobu trvanlivosti!","POZOR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cena s DPH je: "+Ondrementy.CenaDPH());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = Ondrementy.ToString();
        }
    }
}
