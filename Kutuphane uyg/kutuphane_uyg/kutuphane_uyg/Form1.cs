using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace kutuphane_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class kutuphane
        {
            public string k_adi { get; set; }
            public string k_yazari { get; set; }
            public string k_yayinevi { get; set; }
            public int k_sayfa { get; set; }
        }
        SqlConnection bgln = new SqlConnection("Server=BYGURO-PC;Database=kutuphane_uyg;Persist Security Info=True;User Id=sa;Password=123;");

        private void veriekle()
        {
            if (bgln.State != ConnectionState.Open)
            {
                bgln.Open();
            }
            SqlCommand baglan = new SqlCommand("insert into Kitaplar(kitap_adi,kitap_yazari,kitap_yayinevi,kitap_sayfa) values (@kitap_adi,@kitap_yazari,@kitap_yayinevi,@kitap_sayfa)", bgln);
            baglan.Parameters.Add(new SqlParameter("kitap_adi", textBox1.Text));
            baglan.Parameters.Add(new SqlParameter("kitap_yazari", textBox2.Text));
            baglan.Parameters.Add(new SqlParameter("kitap_yayinevi", textBox3.Text));
            baglan.Parameters.Add(new SqlParameter("kitap_sayfa", textBox4.Text));
            baglan.ExecuteNonQuery();
            temizle();
        }
        private void temizle()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox1.Focus();
        }
        private void tablokugoster()
        {
            listView1.Items.Clear();
            if (bgln.State != ConnectionState.Open)
            {
                bgln.Open();
            }
            SqlCommand cmd = new SqlCommand("select *from Kitaplar", bgln);
            SqlDataReader tabloku = cmd.ExecuteReader();
            while (tabloku.Read())
            {
                ListViewItem liste = new ListViewItem();
                liste.Text = tabloku.GetInt32(0).ToString();
                liste.SubItems.Add(tabloku["kitap_adi"].ToString());
                liste.SubItems.Add(tabloku["kitap_yazari"].ToString());
                liste.SubItems.Add(tabloku["kitap_yayinevi"].ToString());
                liste.SubItems.Add(tabloku["kitap_sayfa"].ToString());
                listView1.Items.Add(liste);
            }
            tabloku.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            veriekle();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tablokugoster();

        }
        int id = 0;//sli butunu ve mousedoubleclıkte calısacagı ıcın dısarda tanımladık.
        private void button3_Click(object sender, EventArgs e)
        {

            if (bgln.State != ConnectionState.Open)
            {
                bgln.Open();
            }

            SqlCommand komut = new SqlCommand("DELETE FROM Kitaplar WHERe kitap_adi=('" + textBox1.Text + "')", bgln);
            komut.ExecuteNonQuery();
            tablokugoster();
            //event te mosudoubleclic oz acıyoruz.bu ozelık lıstwıewde tıkladıgımızda verılerı texboxlara yazar.
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            //subsitem 1 den baslattık..0 ındex ataması yaptıgı ıcın eklemedık
        }


    }
}
