using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ginklu_Parduotuve
{
    public class Ginklas
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual void Equal(List<Ginklas> f, List<Ginklas> s, int i)
        {
            f.Add(new Ginklas { Name = s[i].Name, Price = s[i].Price});
        }
    }
}
