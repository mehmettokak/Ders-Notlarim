using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fieldlar_sınıficindeki_degiskenler__prprty
{
    class isimsoyisim
    {
     /*                         Propertyler 
      * Biz programcılar genellikle field ların(degıskenlerin) dısarıdan erısım olsun ıstemeyız.Yani Direkt erisim olmasını ıstemeyız.
      * buneden den dolayı ilk olarak fieldımız prıvate olarak tanımlarız.sonrasonda proprty olarak yazarız.
      * field prıvate oladugu zaman dısardan erısılmez ve okunmaz..
      * fakat bu fieldın dısarı acıcak bır yapısı olması gerekıyor..o da property dıdır.
      * property =>fieldları kontrollu bır sekılde dısarıya acar.
      */
        private string ad;//ilk etapta erısılmesın Fakat farklı degısken adı altında ılk degıskene atama yapsın..
        public string Adım//veya isim da yazılır//prop fiel adı yukarıdakı ad gıbı aynı olmıyacak..kesinlikle farklı olucak.ad ıda farklı degiskene atar ordan da ad fieldına atama yapar.
        {   //set fielda dısardan deger atamak ıcın kullanılır.value dısardan atanan degerı bekler,onu yazar
            //deger okuma yapar
            // set te deger almadan once kontrol yapılabılır.
set { ad = value.ToUpper(); } //gelen deger buyuk harfe cevır dedık
            //atanan deger neyse o degeri geri dondurerek dısarı yazırır.
            get { return ad; }

        }
       
       
    }
}
