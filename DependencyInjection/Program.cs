// See https://aka.ms/new-console-template for more information
using DependencyInjection;

Console.WriteLine("Hello, World!");

Manager m = new Manager();
m.FirstName = "Çağrı";
m.LastName = "Şakar";



Employee employee = new Employee();
m.FirstName = "Fatih";
m.LastName = "Çakıroğlu";

Person p = m; //abstract sınıfa bir atama yapabiliriz ama new ile nesne üretemeyiz.!!

//((Manager)p).ManagerMethod    //Manager methoda p üzerinden ulaşabilmemiz için burada cast işlemi yapıyoruz. complier hata vermez boyle yaparsak.

void Calculate(Person person) //bir metod da meneger ve employee ye ayrı ayrı işlem böyle yaptırabiliriz.
{
    if (person is Manager)
    {

    }

}


Console.WriteLine(m.FullName);
