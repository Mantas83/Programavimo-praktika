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
    public partial class Form1 : Form
    {
        List<Ginklas> ginklai = new List<Ginklas>();
        List<Basket> bs = new List<Basket>();
        public Form1()
        {
            InitializeComponent();

            LoadGunsList();
        }

        private void LoadGunsList()
        {
            listGunsListBox.Items.Clear();
            ginklai = SqliteDataAccess.LoadGuns();
            for (int i = 0; i < ginklai.Count; i++)
            {
                listGunsListBox.Items.Add(ginklai[i].Name + "    " + ginklai[i].Price + "$    ");
            }
        }
        
        private void Addtobasket_Click(object sender, EventArgs e)
        {
            if (listGunsListBox.SelectedItem != null)
            {
                string item = Convert.ToString(listGunsListBox.SelectedItem);
                for (int i = 0; i < ginklai.Count; i++)
                {
                    if (item.Contains(ginklai[i].Name))
                    {
                        bs.Add(new Basket { Name = ginklai[i].Name, Price = ginklai[i].Price });
                        MessageBox.Show("Ginklas idėtas į jūsų krepšelį");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pirma pasirinkite ginklą");
            }
        }

        private void Gotokrepselis_Click(object sender, EventArgs e)
        {
            bs[0].SetList(bs);
            FormBasket bf = new FormBasket();
            bf.ShowDialog();      }

    }
}
