// See https://aka.ms/new-console-template for more information
using AbstractAndInterface;

Console.WriteLine("Hello, World!");



//Abstract

//Manager m = new Manager();
//m.FirstName = "Çağrı";
//m.LastName = "Şakar";



//Employee employee = new Employee();
//m.FirstName = "Fatih";
//m.LastName = "Çakıroğlu";

//PersonAbstract p = m; //abstract sınıfa bir atama yapabiliriz ama new ile nesne üretemeyiz.!!

////((Manager)p).ManagerMethod    //Manager methoda p üzerinden ulaşabilmemiz için burada cast işlemi yapıyoruz. complier hata vermez boyle yaparsak.

//void Calculate(PersonAbstract person) //bir metod da meneger ve employee ye ayrı ayrı işlem böyle yaptırabiliriz.
//{
//    if (person is Manager)
//    {

//    }

//}

//Console.WriteLine(m.FullName);



//Interface
IProductRepository pr = new ProductRepository();
pr = new ProductRepositoryOracle(); // bunu eklediğimde oracle dan geliyormuş gibi verileri gösterecek.

ProductService ps = new ProductService(pr);

Console.WriteLine(String.Join(",",ps.GetProductNames()));