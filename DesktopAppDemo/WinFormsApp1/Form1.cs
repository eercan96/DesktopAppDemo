namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("�zeine Geldi");
        }
    }
}
