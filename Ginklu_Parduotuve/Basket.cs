using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ginklu_Parduotuve
{
    public class Basket : Ginklas
    {
        private double Amount { get; set; }
        protected static List<Basket> b;

        public double Payment(List<Basket> b)
        {
            Amount = 0;
            for (int i = 0; i < b.Count; i++)
            {
                Amount = Amount + b[i].Price;
            }
            return Amount;
        }
        public void SetList(List<Basket> B)
        {
            b = B;
        }
        public List<Basket> GetList()
        {
            return b;
        }

    }
}
