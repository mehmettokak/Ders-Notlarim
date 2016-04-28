using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contruster_yapıcı_metot
{
    class Program
    {
        static void Main(string[] args)
        {//ogrencı ogr=new ogrencı ()--burda ogr bır nesnedir.new ogrencı anlamı--ogrencı sınıfındakı fieldve uyelerı ogr ye aktar demektır.
            
 // CONTRUSTER yapcı metot :
    //Bir Sınıfta Nesne Talep edildigi anda nesne olusmadan(ram de nesne olmadan once constructer metot calısır.) calısan metoda denır.
 //bız constructer yapıcı metotla bır kontrol saglamasak arka planda defult constucter calısır.
 //yenı sınıfa ıkı tane field atalım bırı strın ad olsun dıger int isim olsun..
//contrctr olmasan bunları calıstırırsak program ılk etapta strıng ad olanı null bos olarak gosterır.int isim olanı ise 0 gosterır.
//yani stringe null,int 0 deger ataması yapar ılk etapta.herzaman boyle olur..bunu construcer le degıstırebılırız
//ilk etapta kabul edılen bos ve sıfır default gızlı  contructer  kontrol edıyo.
//simdi contructers le kontrolu bı ele gecırecez.
            //CONSRUCTER METOTUN  YAZMA KURALLLARI
            //1.Olusturulan sınıfla aynı isme sahıp olmalıdır.
            //2. Geri Donus Tipi olmayacak.direkt erısım belırleyıcıyle beraber ısmını yaızıcaz
            //consructer metot calısmadan ram da nesne uretılmez.
            //metot yazılırken oncelıkle erısım belırleyıcı yazılır.
            //ozetle yenı olusturdugumuz sınfa olusturdugummuz fielde sabot bır  degerı olsun ıstıyorsak consructer metotla yapmalıyız.
            //suna benzer.degıskennızı int a=5 olsun dıyoruz ya 5 olması ıcın conrtcturla atama yapıcaz.cntrcter mttla yapılır.
                                                         // yada a=dısardan deger alsın.bu da parametrelı cntrcter metotla yapılır.

            Ornek deger = new Ornek();//parametre yok parametresız cntrctr calısır.sınfta tanımlanan 5 rakamını alır
            Console.WriteLine(deger.sayı);
            Console.WriteLine("**************************************************** ");
            Ornek sayımız = new Ornek(10);//parametre oldugu ıcın parametrelı cntrctr calısır 10 degerını atar
            Console.WriteLine(sayımız.sayı);


        }
    }
}
