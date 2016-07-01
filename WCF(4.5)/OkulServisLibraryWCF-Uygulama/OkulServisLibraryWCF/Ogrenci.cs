using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OkulServisLibraryWCF
{
    //ögrenci clasınıd dış dunya ya sunmak için ,yani dısardaki kullanıcıların bizim oluşturduğumuz ögrenci class ına (nesnesine) ulaşabilmesi için datacontract attibut u ile süslememiz gerekiyor. 
    [DataContract]
   public class Ogrenci
    {
        [DataMember]
        public int ogrenciId { get; set; }

        [DataMember]
        public string ogrenciAdi { get; set; }

        [DataMember]
        public string ogrenciSehri { get; set; }
    }
}
