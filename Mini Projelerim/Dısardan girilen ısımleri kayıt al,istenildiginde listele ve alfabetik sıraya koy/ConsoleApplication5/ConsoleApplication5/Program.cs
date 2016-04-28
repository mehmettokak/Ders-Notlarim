﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int s = 0;
            string sorular = "";
            bool a = true;
            string[] dizi = null;
            Console.WriteLine("Online Sınav olusturma Sistemine Hosgeldiniz.Sınav Soruları Hazırlamak için bir tusa basıp baslayabilirsiniz.\n");

            while (a)
            {
                s++;
                Console.WriteLine(s + ". Soruyu yazınız ?");
                sorular = Console.ReadLine();
                if (sorular == "listele")
                {
                    a = false; Console.WriteLine("Toplam " + s + " adet sorunuz eklenmistir.\n"); Console.WriteLine(string.Join("\n", dizi));

                    foreach (string item in dizi)
                    {
                        if (dizi != null)
                            k++; Console.WriteLine(k + ".Sorunuz :" + item);
                    }

                }

                else { dizi = ynidiziolstur(dizi, sorular); Console.WriteLine(s + ". Sorunuz başarıyla eklenmistir.\n"); }
            }

        }

        static string[] ynidiziolstur(string[] dizi, string sorular)
        {
            string[] yenidizi;
            if (dizi == null)
            {
                yenidizi = new string[1];
            }
            else
            {
                yenidizi = new string[dizi.Length + 1];
                for (int i = 0; i < dizi.Length; i++)
                {
                    yenidizi[i] = dizi[i];
                }
            }

            yenidizi[yenidizi.Length - 1] = sorular;

            return yenidizi;

        }


    }
}
