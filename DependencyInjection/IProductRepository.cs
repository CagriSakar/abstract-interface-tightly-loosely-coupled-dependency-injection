using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    public interface IProductRepository
    {
        List<string> GetList(); // bunu artık contract olarak görücez. Kim bu interface i implement ederse bu metodların gövdelerini dolduracak.
    }
}
