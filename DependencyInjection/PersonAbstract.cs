using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public abstract class PersonAbstract //abstract class demek soyutlanmış sınıf demek. eğer bir nesne new ile üretilemiyorsa biz buna soyut kavram deriz. Burada abstract dememiz önemli. Çünkü bu sınıf bizim asıl sınıfımız değil miras almak için kullanıyoruz. Bir başkası bu sınıftan nesne üretmemeli. O yüzden sınıfımızı soyutluyoruz.
    {
        public string? FirstName { get; set; }
        public string LastName { get; set; }   //burada altı yeşil çizili olmasının nedeni nullable özeliğinin .net6 da enable geldiği için bize nullable olabileceğini söylüyor ide. Eğer string ifadesinin yanına ? işareti eklersek bunun nullable olabileceğini bildiğimizi göstermiş oluruz ve yeşil çizgi gider.Bu runtime da bir değişiklik yaratmaz. 
        
        public int Age { get; set; }
        public string FullName => $"{FirstName} {LastName}"; //tek satır mesaj gövdesi olacak şekilde lamda ile ilerleyebiliriz. Ama bu durumda sadece FullName get olur seti olmaz. Zaten bizim de method olarak ihtiyacımız yok buna. Property olarak kalabilir.


        public abstract void SalaryCalculate(); //bu metodu abstract yaptığım anda (sadece imzası var gövdesi yok) Person sınıfından miraz alan classların implement etmesi gerekir artık (zorunlu olarak). Yani alt sınıflara da sözleşmeye bağlı kalmayı zorluyorsun. Buna abstractlerde contract tanımlama denir.

        //Abstract bir method varsa sınıfta mutlaka abstract olmalı.!!

        public decimal BaseSalaryCalculate() //Abstract demediğin anda mesajın gövdesini kendin kodlayacaksın.
        {
            return 10M;
        }
    }

    public class Manager : PersonAbstract
    {
        public override void SalaryCalculate() //abstract sınıfları override ile ezebiliyoruz.
        {
            decimal baseSalary=BaseSalaryCalculate();
        }
        public void ManagerMethod()
        {

        }
    }

    public class Employee : PersonAbstract
    {
        public override void SalaryCalculate()
        {
            throw new NotImplementedException();
        }
    }
}