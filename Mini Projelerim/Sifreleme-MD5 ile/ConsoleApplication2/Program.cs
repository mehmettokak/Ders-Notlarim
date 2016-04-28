using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "7sdasd744";
            Console.WriteLine("Şifrelenecek Yazı:");
            Console.WriteLine("".PadRight(40, '-'));
            Console.WriteLine(text);
            Console.WriteLine();

            string password = "12345";
            DESEncrypt testEncrypt = new DESEncrypt();
            string encText = testEncrypt.EncryptString(text, password);

            Console.WriteLine("Encrypted Text:");
            Console.WriteLine("".PadRight(40, '-'));
            Console.WriteLine(encText);
            Console.WriteLine();

            Console.WriteLine("Decrypted Text:");
            Console.WriteLine("".PadRight(40, '-'));
            string plainText = testEncrypt.DecryptString(encText, password);
            Console.WriteLine(plainText);

            Console.ReadLine();
        }

    }
}
