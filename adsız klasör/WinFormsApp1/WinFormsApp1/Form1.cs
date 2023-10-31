namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public object Label7 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Cem";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Cem";
            label7.Text = "İlyün";
            label8.Text = "Yazılımcı";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazılım Mühendisliği";
            label9.Text = textBox1.Text;
        }
    }
}