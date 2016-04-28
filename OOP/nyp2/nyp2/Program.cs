using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyp2
{
    class Program
    {
        static void Main(string[] args)
        {
            arabam benimarac = new arabam();
            benimarac.marka = "Seat";
            benimarac.model = "leon";
            benimarac.uretimyılı = 2015;
            Console.WriteLine("aracımın markası : "+benimarac.marka+" aracımın modeli: "+benimarac.model+" uertim yılı: "+benimarac.uretimyılı);
            Console.WriteLine("------------------------------------------------------------------");


            benimarac.hızyukselt();//yukslet
            benimarac.hızyukselt();//oncekı hızına gore tekrar yukselt
            benimarac.hızyukselt();//son hızına gore tekrar yukselt
            Console.WriteLine("------------------------");
            benimarac.hızdusur();//son hızına gore hızı dusur.
            Console.WriteLine("------------------------");
            Console.WriteLine("Suanki Hızım : "+benimarac.hız); //son hıı yazar
        }
    }
}
