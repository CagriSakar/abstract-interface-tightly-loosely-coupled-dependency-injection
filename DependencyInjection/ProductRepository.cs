using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    internal class ProductRepository : IProductRepository //artık PR IPR yi implement edicek
    {
        public List<string> GetList() //gövdesini böyle doldurdu bu metodun.
        {
            return new List<string>() { "ahmet", "mehmet", "hasan" };
        }

        public void InlineMethod() 
        {
            //bunu ProductService in görmemsi lazım. Çok fazla bilgi sahibi olmaması lazım ProductService in
            //Eğer araya bir interface koyarsak A classı B class ını direk bilmeyecek.

        }
    }
}
