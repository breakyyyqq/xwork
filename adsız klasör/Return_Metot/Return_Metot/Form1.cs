﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam(int s1,int s2)
        {
            int s3 = s1+ s2;
            return s3 ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = toplam(4, 6).ToString();
            label2.Text = toplam(2, 3).ToString();
            label3.Text = toplam(4, 8).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
