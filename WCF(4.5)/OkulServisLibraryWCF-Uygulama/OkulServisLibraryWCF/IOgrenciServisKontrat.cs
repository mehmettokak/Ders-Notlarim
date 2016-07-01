using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace OkulServisLibraryWCF
{
    [ServiceContract] //Kontratı dıs dunyaya açtık
  public   interface IOgrenciServisKontrat //bu clası interface ile açtık.
    {
       
        [OperationContract] //Dış dunyaya açık.
        List<Ogrenci> OgrenciListele();//interface oldugu icin metot olarak tanımlamamız gerekir.

        [OperationContract] //Dış dunyaya açık.
        Ogrenci OgrenciGetir(int id);//id ye göre tek bir ogrenci  getiren metod.

        [OperationContract] //Dış dunyaya açık.
        void OgrenciSil(int id);//geriye deger donmeyen id ye gore ogrenci silen metod.

        [OperationContract] //Dış dunyaya açık.
        void OgrenciEkle(Ogrenci ogrenci);// Ögrenci tipinde ogrenci nesnesi alarak ogrenci ekleyebilir.

        //OperationContract yazmadıgımız için dıs dunyaya kapalıdır.kımse erisemez.Serileştirilmeyecek
        void OgrenciGuncelle(Ogrenci ogrenci);// Ögrenci tipinde ogrenci nesnesi alarak ogrenci güncelleyebilir.
    }
}
