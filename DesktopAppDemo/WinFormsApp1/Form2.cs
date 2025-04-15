using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<Alislist> list = new List<Alislist>();

        private void btnShow_Click(object sender, EventArgs e)
        {



            //dataGridView1.DataSource = list.Select(x => new { Deger = x }).ToList();   //linq

            ShowData();
            ClearTextBox();

        }

        public void ShowData()
        {
            dataGridView1.DataSource = list.OrderBy(a => a.Product).ToList();
        }

        public void ClearTextBox()
        {
            txtId.Text = "";
            txtProduct.Text = "";
            txtQuantity.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Alislist alis=new Alislist()
            {
                Quantity = Convert.ToInt32(txtQuantity.Text);
                Product = txtProduct.Text;
                Id = Convert.ToInt32(txtId.Text);
            } ;

            
            list.Add(alis);
            ShowData();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Alislist alislist = new Alislist();

            alislist.Id = 0;
            alislist.Product = "elma";
            alislist.Quantity = 12;
            list.Add(alislist);

            Alislist alislist1 = new Alislist()
            {
                Id = 1,
                Product = "aaa",
                Quantity = 24
            };
            list.Add(alislist1);
        }
    }
}
