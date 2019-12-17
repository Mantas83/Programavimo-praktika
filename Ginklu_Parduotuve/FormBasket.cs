using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginklu_Parduotuve
{
    public partial class FormBasket : Form
    {
        List<Basket> B = new List<Basket>();
        public FormBasket()
        {
            InitializeComponent();
            Basket b = new Basket { Name = "", Price = 0};
            B = b.GetList();
            Refresh(B);
        }

        private void Refresh(List<Basket> b)
        {
            listBox1.Items.Clear();
            if (b.Count > 0)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    listBox1.Items.Add(b[i].Name + "    " + b[i].Price + "$    ");
                }
              textBox1.Text = "Bendra kaina: " + Convert.ToString(b[0].Payment(b) + "$");
            }
            else
            {
                listBox1.Items.Add("Jūsų krepšelis tusčias");
                listBox1.Enabled = false;
                textBox1.Text = ("Jūsų krepšelis tusčias");
            }
            textBox1.Enabled = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                B.RemoveAt(listBox1.SelectedIndex);
                Refresh(B);
            }
            else
            {
                MessageBox.Show("Pasirinkite Ginkla kurį norite panaikinti iš krepšelio");
            }
        }

        private void Atgal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            if (listBox1.Items == null)
            {
                MessageBox.Show("Jūsų krepšelis tusčias!");
            }
            else
            {
                MessageBox.Show("Saskaita issaugota!");
                List<Bill> bill = new List<Bill>();
                bill.Add(new Bill { Name = B[0].Name, Price = B[0].Price, Amount = 1 });
                bill[0].YourBill(B);
            }

            listBox1.Items.Clear();
        }
    }
}
