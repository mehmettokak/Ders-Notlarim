using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyp2
{
    class arabam
    {
        public string  marka;
        public string model;
        public int uretimyılı;
        public int hız;
        //degişken elemanlarımızı her yerde erısıme acık olacak sekılde tanıttık
        //sımdı her yerde erısıme acık fakat gerıye donmeyen(voıd) metotla ıslem yaptıralım
        public void hızyukselt()
        {
            hız = hız + 10;
            Console.WriteLine("Yukselen Hızınız : "+hız);



        }
        public void hızdusur()
        {
            hız = hız - 10;
            Console.WriteLine("dusurulen hızınız : " +hız);

        }




    }
}
