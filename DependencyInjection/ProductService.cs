using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    //public class ProductController //bağımlı nesne
    //    {
    //        public string Get()
    //        {
    //            ProductService productService = new ProductService(); //bağımlılık nesnesi

    //            return productService.GetProductNames();

    //        }
            
    //    }

    internal class ProductService //interface bizim soyutlamayı yaptığımız yerdir.
    {
        private readonly IProductRepository _productRepository;   //böyle yaparak new den kurtulduk. Artık PS PR yi bilmiyor.
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        
        //public List<string> GetProductNames()
        //{
        //    var prductRepository = new ProductRepository(); //burada ProductRespository bağımlılık nesnesidir ProductService görevini yerine getirmek için PR metoduna bağımlılık duyuyor. Bunu new ile oluşturmamam lazım
        //    return prductRepository.GetList();

        //    //1. bu nesneleri benim yaratmamam lazım bunlar bana constractor dan gelmesi lazım.
        //    //2.

        //}

        public List<string> GetProductNames()
        {
            return _productRepository.GetList(); // public olarak hiç bişiyi görmüyor artık PS sadece elimde getlist var.
        }





    }
}
