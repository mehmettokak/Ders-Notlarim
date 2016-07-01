using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServis
{
    //uzantı asmx ise webservis projesi demektir.
    //Web Serviste kullanılan standartlar :
    // XML=>Veri alış verişlerinde kullanılanılır.
    // WSDL(WebServis Description Language) => Kullanıcılar webservis arayuz hakkında bilgi sunar.
    // DİSCO (Discovery Protokol) Sunucuya açılmış paylaşımdaki servislerin organizasyonunu sağlar.(onu alıp oraya bunu alıp buraya gibi işlemlerde kullanıyor.)
    // UDDI =>İnternet üzerinde açılmış ve uygulamalar tarafında kullanılabilecek web servis organizasyonunu saglar.
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
 
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]//Metodumuz Web serviste kullanılabilir demektir.Yazılmasa kullanılmaz.
        public string HelloWorld()
        {
            return "Hello World";
        }
         [WebMethod]//webserviste kullanılabilir yaptım.
        public DataTable urungetir()
        
        {
             //Haber databasesinden haber tablosunu cektim.Bunu serviste invok edersek xml cıktısı gozukur.
            SqlConnection cnn = new SqlConnection("Server=BYGURO-PC;Database=Haber;User Id=sa;Password=123;");
            cnn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Haber", cnn);
            DataTable dt = new DataTable("Haber");
            adp.Fill(dt);
            return dt;
        }
    }
}