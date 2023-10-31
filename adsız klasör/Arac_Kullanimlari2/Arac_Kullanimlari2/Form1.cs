using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kasiyer");
            listBox1.Items.Add("Futbolcu");
            listBox1.Items.Add("Muhasebeci");
            listBox1.Items.Add("Antrenör");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // ad soyad meslek yaş maaş . tek sırada yazdırılacak 
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text + " " + textBox4.Text + " " + textBox1.Text + " " + textBox2.Text + " " + textBox5.Text);
        }
    }
}
