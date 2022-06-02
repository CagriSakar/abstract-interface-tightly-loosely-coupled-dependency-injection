//--Tightly Coupled--
// Kod parçacığı çalışabilmek için bir nesneye ihtiyaç duyuyorsa bu kod o nesneye sıkı sıkıya bağlı olduğu anlamına gelir.
//Interface'i anlatırken örnek yazdığımız kodları ele alırsak, 

//internal class ProductService
//{
//    public List<string> GetProductNames()
//    {
//        var prductRepository = new ProductRepository(); 
//        return prductRepository.GetList();
//    }
//}

//Görüldüğü gibi ProductService görevini yerine getirmek için ProductRepository metoduna bağımlılık duyuyor.Ona sıkı sıkıya bağlı. PR de yapılacak bir değişiklik PS sınıdını direkt olarak etkileyecek. Yeni bir şey eklemek istediğimde bu sıkı bağlar bizim kodlarımızı birbirine dolayacak. Her bir sınıf birbirine bağımlı olacak.
//Bu bizim istediğimiz bir durum değil.


//--Loosely Coupled--
//Kodumuzda sürekli genişleme ihtiyacı olabilir. Örneğin ödeme yöntemiyle ilgili sadece kredi kartı ile bir ödeme yöntemi geliştirdik. Yarın bizim kodumuza sms ile bir ödeme yöntemide eklenebilir. Bu durumları görerek, yazdığımız kodun kolayca genişletebilmesi gerekir. Sıkıca bağlı yapılarda bu kodu değiştirmeden pek mümkün olmuyor.
//Gevşek bağlı sistemler kurmanın en önemli aktörleri interfacelerdir. Çünkü interfaceler classların arayüzleri, imzalarıdır.
//Yukarıdaki örneğimize dönecek olursak ProductRepository class ını IProductRepository den kalıtıp bu sayede ProductService'in ProductRepository bağımlılığını kaldırırız.
//Bu interfacesi kalıtan tüm classlar metodunu implemente etmek zorunda.
//Böylelikle new anahtar kelimesi ile bir nesne oluşturmak zorunda kalmayız.
//Yani A class'ı B class'ını direk olarak tanımaz. Aradaki interface sayesinde birbirerini tanıyabilirler. Diyelimki yarın database değişikliği yapıldığında B class'ı yerine C class'ı geldiğinde kolaylıkla bu değişimi yapabiliriz. Çünkü classlarımız birbirine sıkı sıkıya bağlı değiller, gevşek bağlılar (LOOSELY COUPLED)

//Önemli olan KODUN KOLAYCA GENİŞLEMESİ AMA KOLAYCA DEĞİŞMEMESİDİR.


//--Dependency Injection--
//Dependency injection adından da anlaşılacağı üzere bağımlılıkları enjekte etme yöntemi sunan prensiptir. Dependency injection ile bağımlı olduğunuz classları ana classınızda new ile  yaratmak yerine onları enjekte ederiz.
//Constructor injection
//Propery injecion
//Method injection
//Ambient context
//Service locator
//gibi bir sürü bağımlılıkları injection yöntemi vardır.

//--Polymorphism--(Çok Biçimlilik)



//--S.O.L.I.D. Prensipleri--

//D.(Dependency Inversion Priciple)

//Robert C.Martin => Componentler, bileşikler her zaman abstraction(soyutlama) üzerine bağlı olacak.
//A class ı B class ını direk tanımamalı. Bunun için araya Interface koyucaz. A class ı Interface i bilecek.
//Inversion kelimesi terse çevirmek demek. 
//Örnek kodumuza bakarsan ProductService'in içinde GetAll metodumuz var. Akışa bakarsak PS in nasıl davranış sergilediği GetAll metoduna bağlı yani aşağıdan yukarıya doğru bir yön var.
//Araya eğer ben bir kod getirirsem yani interface üzerinden alırsa yani ben böyle bir soyutlama yaptığımda akışı tersine çevirmiş oluyorum. PS i kullanırken buna PR verirsem datalar PR den geliyor ama PRO verirsem PRO dan geliyor yani method üzerinde hiç bir değişiklik yapmıyorum. Kod artık YUKARIDAN AŞAĞIA doğru bir yön var.
//Özetle bir classın davranışını dışardan değiştirebiliyorsak artık onu inversion yapmışız anlamına geliyor. 

//KOD GELİŞİME AÇIK DEĞİŞİME KAPALI OLMALI.


//S. (Single Responsibility Principle)
//Tek sorumluluk prensibi.
//Bir classın değişmesi için tek bir sebebi olmalı.Bir class hem fax gönderiyor hem sms gönderiyorsa bunları iki ayrı class yap.

//O. (Open-Closed Principle)
//Kodun gelişime açık değişime kapalı olmalı. Var olan şeyleri değiştirme.

//L. (Liskov Substitution Principle)
//