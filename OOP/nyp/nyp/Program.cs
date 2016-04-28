using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyp
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgi kisiselbilgiler = new bilgi();
            //Console.WriteLine(kisiselbilgiler.hosgeldiniz("mehmet","tokak"));
            //bu sekılde kullanılabılır.
            string sonuc = kisiselbilgiler.hosgeldiniz("mehmet", "tokak");
            Console.WriteLine(sonuc);

            
            
            //return gerıye donen oldugu ıcın bır sonuc degıskene atadık.
            

        }
    }
}
