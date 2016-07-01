using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulServisLibraryWCF
{
    //Oluşturduğumuz kontratta bulunan metotlara bir kullanıcı istek gönderirse ne yapılması gerektiğini servis belirleyecek. Yani oluşturduğumuz interfaceyi(kontratı) implemente etmemiz gerekir
    public class OgrenciServis : IOgrenciServisKontrat// ctrl. deyince konrat içindeki metotlar buraya dahil edilir.
    {
        List<Ogrenci> Veritabanım = new List<Ogrenci>();//bunu veri abanı olarak dusunelim.
        public List<Ogrenci> OgrenciListele()
        {
           
            return Veritabanım;//Veri tabanımı dondursun
        }

        public Ogrenci OgrenciGetir(int id)
        {
            return Veritabanım.FirstOrDefault(s => s.ogrenciId==id);
        }

        public void OgrenciSil(int id)
        {
             Veritabanım.Remove(Veritabanım.FirstOrDefault(s => s.ogrenciId == id));//gelen id ye gore ogrenci silecek
        }

        public void OgrenciEkle(Ogrenci ogrenci)
        {
             Veritabanım.Add(ogrenci);//gelen ogrenci nesnesi veritabanıma eklenecek
        }

        public void OgrenciGuncelle(Ogrenci ogrenci)
        {
            throw new NotImplementedException();//gunclleme dısarıya acık olmadıgı ıcın ıslem yapmadık.
        }
    }
}
