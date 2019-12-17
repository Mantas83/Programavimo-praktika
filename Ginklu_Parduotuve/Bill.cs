using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ginklu_Parduotuve
{
    public class Bill
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        List<Bill> B = new List<Bill>();
        public void YourBill(List<Basket> BS)
        {
            for (int i = 0; i < BS.Count; i++)
            {
                B.Add(new Bill { Name = BS[i].Name, Price = BS[i].Price, Amount = 1 });
            }

            for (int i = 0; i < B.Count; i++)
            {
                for (int j = i + 1; j < B.Count; j++)
                {
                    if (B[i].Name == B[j].Name)
                    {
                        B[j].Amount++;
                        B.RemoveAt(i);
                    }
                }
            }

            TextWriter tw = new StreamWriter("Saskaita.txt");
            tw.WriteLine(string.Format("{0:HH:mm:ss tt}", DateTime.Now));
            tw.WriteLine("---------------------");
            for (int i = 0; i < B.Count; i++)
            {
                tw.WriteLine(B[i].Name + " " + B[i].Amount + " " + B[i].Price + "$ ");
            }
            tw.WriteLine("---------------------");
            tw.WriteLine("Kaina " + BS[0].Payment(BS) + "$");
            tw.Close();
        }
    }
}
