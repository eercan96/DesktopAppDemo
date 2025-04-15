using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        }

        public void ShowData()
        {
            dataGridView1.DataSource = list.OrderBy(a => a.Product).ToList();
        }

        public void ClearTextBox()
        {
            txtId.Text = (Convert.ToInt16(txtId.Text) + 1).ToString();
            txtProduct.Text = "";
            txtQuantity.Text = "";
            txtProduct.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = CheckIfTextBoxIsEmpty();
            if (result)
            {
                var result2 = CheckIdIsExists(Convert.ToInt16(txtId.Text));
                if (result2)
                {
                    Alislist alis = new Alislist()
                    {
                        Quantity = Convert.ToInt16(txtQuantity.Text),
                        Product = txtProduct.Text,
                        Id = Convert.ToInt16(txtId.Text)
                    };


                    list.Add(alis);
                    ShowData();
                    ClearTextBox();
                }


            }

        }

        bool CheckIfTextBoxIsEmpty()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("ID boş");
                return false;
                txtId.Focus();

            }
            else if (txtProduct.Text == "")
            {
                MessageBox.Show("Product boş");
                return false;
                txtProduct.Focus();

            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Quantity boş");
                return false;
                txtQuantity.Focus();

            }
            return true;
        }

        bool CheckIdIsExists(int id)
        {
            foreach (var item in list)
            {
                if (item.Id == id)
                {
                    MessageBox.Show("Id kullanılmış");
                    txtId.Focus();
                    return false;
                }

            }
            return true;
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, "[^0-9]"))
            {
                MessageBox.Show("Sayı gir");
                txtId.Text = txtId.Text.Remove(txtId.Text.Length - 1);
                txtId.SelectionStart= txtId.Text.Length;

            }

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtQuantity.Text,"[^0-9]"))
            {
                MessageBox.Show("Sayı gir");
                txtId.Text = txtId.Text.Remove(txtId.Text.Length - 1);
                txtId.SelectionStart = txtId.Text.Length;

            }
        }
    }
}
