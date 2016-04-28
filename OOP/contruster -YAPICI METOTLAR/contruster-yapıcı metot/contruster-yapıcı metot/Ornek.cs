using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contruster_yapıcı_metot
{
    class Ornek
    {
        public int sayı;//field belirledik.
        
        //consructer sınıf adıyla aynı olmak zorundadır.
        public Ornek() //consructer metot old ıcın () bulunmak zorundadır.parametre almaz-int ve strıng vb  yazılmaz.
        {
//consructer olstrduk..bu anda ram dekı default consructer devre dısı kaldı-ıptaloldu.bızım consructerımız calısacak
            sayı = 5;
        }
        public Ornek(int gelen)//2. cnsrctr ı olusturduk.bu da dısardan ınt parametresı alır.
        {//nesne olustururken dısardan parametre deger gırılırse parametrelı constrctr aktıf olur
            //pramaetre yoksa parametresız cnstrctr aktıf olur.
            sayı = gelen;
        }
    }
}
