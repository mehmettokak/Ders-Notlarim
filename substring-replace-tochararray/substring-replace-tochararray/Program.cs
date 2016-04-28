using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring_replace_tochararray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeofizik Mühendisi ");

            Console.WriteLine("-------------------------------------------------------------------");

            string cumle = "jeofizik Mühendisi";
            string yenicumle = cumle.Replace("jeofizik", "Yazılım"); Console.WriteLine(yenicumle + ".....(replace örneği=jeofizik yazılım olarak degıstırdı.)");
                                                  //  Console.WriteLine(cumle.Replace("jeofizik", "Yazılım")); seklindede yazılabilir.
           
            Console.WriteLine("-------------------------------------------------------------------------");

            string yenicumle1 = cumle.Substring(2, 5); Console.WriteLine(yenicumle1 + ".....(Substring örneği=2. harften sonra 5 harf  alır gosterir.)");

            Console.WriteLine("-------------------------------------------------------------------------");
            char[] yenicumle2 = cumle.ToCharArray(3, 5); Console.WriteLine(yenicumle2); Console.WriteLine(".....(tocchararray=3.harften sonra 5 harf alır gosterır.)");
           
            Console.WriteLine("-------------------------------------------------------------------------");
            char[] yenicumle3 = cumle.ToCharArray(); Console.WriteLine(string.Join(" ",yenicumle3));
            Console.WriteLine(".....(tochaarray()=harf dızısı olusur.Bunu stringjoınle gosterırız.");
            Console.WriteLine("-------------------------------------------------------------------------------");
            int yenicumle4 = cumle.Length; Console.WriteLine(yenicumle4+"    ........karakter sayısı verır.boslukta dahıl");
            Console.WriteLine("---------------------------------------------------------------------");
            string yenicumle5 = cumle.Remove(5, 10); Console.WriteLine(yenicumle5+"   ....... 5.harften baslar 10.harfe kadar siler.");
            Console.WriteLine("--------------------------------------------------");
            string yenicumle6 = cumle.Replace("fizik", string.Empty); Console.WriteLine(yenicumle6+"  .....replace=fizik kelimesini bos yapar, kalanı yazar.");
            Console.WriteLine("-----------------------------------------------");
            string yenicumle7 = cumle.Substring(10); Console.WriteLine(yenicumle7+" .... 10.harften sonrakı harfleri sonuna kadar alır.");
            Console.WriteLine("------------------------------------------------");
            char[] yenicumle8 = cumle.ToCharArray();
            








        }
    }
}
