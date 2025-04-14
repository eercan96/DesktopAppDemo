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
            //MessageBox.Show("Merhaba");
            Form2 form2 = new Form2();
            form2.Show();
            //this.Hide();


        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Üzeine Geldi");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Programý kapatmak istiyor musun", "Kapatmak", MessageBoxButtons.YesNo)==DialogResult.Yes) this.Close();
        }
    }
}
