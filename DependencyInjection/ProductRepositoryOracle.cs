using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    internal class ProductRepositoryOracle : IProductRepository //diyelim ki db değişti oracle oldu. hiç bir şeyi değiştirmeden böyle yapabiliriz. Program.cs de  pr= new PRO yapıcaz.
    {
        public List<string> GetList()
        {
            return new List<string>() { "oracle ahmet", "oracle mehmet", "oracle hasan" };
        }
    }
}
