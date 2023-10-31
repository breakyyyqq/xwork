using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Ahmet", "Mehmet,", "Aslı", "Hakan", "Ayşe", "Demet" };
            //label1.Text= kisiler[4];

            //int[] sayilar = { 4, 7, 5, 6, 9, 8, 2, 3 };
            //label1.Text = sayilar[5].ToString();

            //double[] sayilar2 = { 3, 4, 6, 7, 8, 9, 10, };
            //label1.Text = sayilar2[5].ToString();

            //string[] sehirler = { "Ankara", "Eskişehir", "Antalya", "Adana", "Bursa", "Balıkesir" };
            //for (int i = 0; i < sehirler.Length; i++) 
            //{
            //    listBox1.Items.Add(sehirler[i]);    
            //}

            int[] sayilar = { 4, 2, 3, 1, 5, 6, 7, 9 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]% 2 ==0) 
                {
                    listBox1.Items.Add(sayilar[i]); 
                }
            }
        }
    }
}
