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
namespace Öğrenci_Kayıt_Sistemi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti=new SqlConnection("Data Source=Burhan\\SQLEXPRESS;Initial Catalog=ÖgrenciKayitSistemi;Integrated Security=True;");
        void temizle()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into ÖgrenciTables(ÖgrenciAD,ÖgrenciSOYAD,DogumTarihi,Mail,KayitTarihi)values(@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1",textBox2.Text);
            komut.Parameters.AddWithValue("@p2",textBox3.Text);
            komut.Parameters.AddWithValue("@p3",maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4",textBox4.Text);
            komut.Parameters.AddWithValue("@p5",maskedTextBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form kayitlistesi= new Form2();
            kayitlistesi.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil=new SqlCommand("Delete From ÖgrenciTables where ÖgrenciID=@s1",baglanti);
            komutsil.Parameters.AddWithValue("@s1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
