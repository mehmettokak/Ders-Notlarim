using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forrr_donngusu
{
    class Program
    {
        static void Main(string[] args)
        {// 1-50 arası sayıları ekrana yazdırma

            //for (int i = 1; i <=50; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1-10 kadar olan sayıların karesını ekrana yazdır
            

            // Girilecek sayı kadar mesaj yazdır

            //Console.WriteLine("Mesaj Yazınız :");
            //string yazi = Console.ReadLine();
            //Console.WriteLine("Mesajınız Kac Kere Yazılsın :");
            //int sayi =Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <=sayi; i++)
            //{
            //    Console.WriteLine(i+". Mesaj : " +yazi);
            //}


            // 1-50 arasındaki çift sayıları vve tek sayıları topla.

            int a=0;
            Console.WriteLine("Cift Sayılar");
            for (int i = 0; i <= 20; i=i+2)
            {
                a = a + i;
  
            }
            Console.Write(a);


           
            Console.WriteLine();
            Console.WriteLine("---------------------");
            
            int b = 0;
            Console.WriteLine("Tek Sayılar");
            for (int i = 1; i <=20; i=i+2)
            {
                b = b + i;
                
            }
            Console.Write(b);


            Console.WriteLine();
             
        }
    }
}
