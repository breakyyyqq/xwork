using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;   

            label5.Text = btn1.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
              
            }
            else
            {
                yanlis++;
                lblyanlıs .Text = yanlis.ToString();    
                pictureBox1 .Visible = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btn1 .Enabled = false;
            btn2 .Enabled = false;  
            btn3 .Enabled = false;
            btn4.Enabled = false; 
            
            label5.Text=btn2.Text;
            if(label4.Text==label5.Text)
            {
                dogru++;
                lbldogru.Text= dogru.ToString();
                pictureBox2.Visible = true; 
            
            }
            else
            {
                yanlis ++;  
                lblyanlıs.Text = yanlis.ToString(); 
                pictureBox1 .Visible = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;   
            btn4.Enabled = false;

            label5.Text=btn4.Text;  
            if(label4.Text == label5.Text)
            {
                dogru ++;
                lbldogru .Text= dogru.ToString();
                pictureBox2.Visible = true; 
            }
            else
            {
                yanlis++;
                lblyanlıs .Text = yanlis.ToString();    
                pictureBox1 .Visible = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btn1 .Enabled = false;
            btn2 .Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;

            label5.Text=btn3.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text= dogru.ToString();
                pictureBox2.Visible = true; 
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString(); 
                pictureBox1 .Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2 .Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn3 .Enabled = false;
            btnsonraki.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2 .Visible = false;   

            
            soruno++;
            lblsoru.Text = soruno.ToString();   

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btn1.Text = "1920";
                btn2.Text = "1921";
                btn3.Text = "1922";
                btn4.Text = "1923";
                label4.Text = "1923";
               
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi İl Ege bölgemizde bulunmaz? ";
                btn1.Text = "İzmir";
                btn2.Text = "Balıkesir";
                btn3.Text = "Aydın";
                btn4.Text = "Manisa";
                label4.Text = "Balıkesir";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son kuşlar hangi yazarımıza aittir?";
                btn1.Text = "Sait Faik";
                btn2.Text = "Cemal Süreya";
                btn3.Text = "Atilla İlhan";
                btn4.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                btnsonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;   
                btn4.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        }
    }
}
