using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KullanicilarinWebServiseErisipBilgiAlmasi

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //servis1soapclient=>servis1 Karsı taraftaki web seriv adı asmx uzantılı olan.Soapclient=>soap elemanına uygun bir tane istemci olustur.
            Baglandigimizwebservis.Service1SoapClient mehmet = new Baglandigimizwebservis.Service1SoapClient();//ornek aldık.
            //burada karsı tarafın olusturdugu metotları gorebiliyoruz.
           dataGridView1.DataSource= mehmet.urungetir();//urun bilgilerini gridviev ımıza ekledik.
            //Karsı taraftan urunleri alırken uzaktakı bilgisayar a baglanacak.baglandıgı bilg ip ,kadi,ksifre,hangi tablodan geldiğini bilmiyor.Sadece sonuc alıyor.
          //  bilgi xml gelmesine karsın ben datnet uyg geliştirdiğim için bana geriye datatable verdiği için ben burda direkt datatable olarak alıyorum.Dolayısıyla benım xml ile ugraşmama gerek kalmıyor.bunu yapan serilazerdir.karsı tarftan gelen xml bılgısı serilazer edilerek data tableye donusuyor benım projemde.
        }
    }
}
