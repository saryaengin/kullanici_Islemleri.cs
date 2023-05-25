using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace hafta13
{
    public partial class Form1 : Form
    {
        private OleDbConnection baglanti = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
        }

        OleDbCommand komut = new OleDbCommand();
        private void btnKytEkle_Click(object sender, EventArgs e)
        {

            komut.CommandText = "INSERT INTO adresler (TcNo,Ad,Soyad,Adres)" + " values('" + txtTcNo.Text + "','" + txtAd.Text + "','" +
                                txtSoyad.Text + "','" + txtAdres.Text + "')";

            baglan();

            if (komut.ExecuteNonQuery() == 1 )
            {
                MessageBox.Show("Kayıt Yapıldı");
                baglanti.Close();
                verileriGetir();
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı");
            }

            txtVerileriniTemizle();

        }

        void txtVerileriniTemizle()
        {
            txtTcNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtAdres.Clear();
            txtTcNo.Focus();
        }

        DataSet ds = new DataSet();
        void verileriGetir()
        {
            try
            {
                baglan();

                ds.Clear();
                komut.CommandText = "Select * from adresler";
                OleDbDataAdapter verial = new OleDbDataAdapter();
                verial.SelectCommand = komut;
                verial.Fill(ds, "adresler");
                dgVeriler.DataSource = ds.Tables["adresler"];
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "data source=adresDefteri.mdb";
            komut.Connection = baglanti;
            verileriGetir();
            txtTcNo.Focus();
        }

        private void BtnKytSil_Click(object sender, EventArgs e)
        {
            komut.CommandText = "Delete from Adresler Where TcNo='" +
                                txtTcNo.Text + "'";
            baglan();

            if (komut.ExecuteNonQuery() == 1)
                MessageBox.Show("Kayıt Silindi..");

            else
                MessageBox.Show("Kayıt Silinemedi.Tekrar deneyiniz.");
            baglanti.Close();
            verileriGetir();
            txtVerileriniTemizle();

        }

        private void dgVeriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTcNo.Text = dgVeriler.Rows[seciliKayit].Cells[0].Value.ToString();
            txtAd.Text = dgVeriler.Rows[seciliKayit].Cells[1].Value.ToString();
            txtSoyad.Text = dgVeriler.Rows[seciliKayit].Cells[2].Value.ToString();
            txtAdres.Text = dgVeriler.Rows[seciliKayit].Cells[3].Value.ToString();
        }

         int seciliKayit;
        private void dgVeriler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            seciliKayit = e.RowIndex;
        }

        private void btnKytGuncelle_Click(object sender, EventArgs e)
        {
            komut.CommandText = "Update Adresler set Ad='" + txtAd.Text +
                                "',Soyad='" + txtSoyad.Text + "',Adres='" + txtAdres.Text +
                                "' Where Tcno='" + txtTcNo.Text + "'";
            baglan();

            if (komut.ExecuteNonQuery() == 1)
                MessageBox.Show("Kayıt Güncellendi..");
            else
            MessageBox.Show("Kayıt Güncellenmedi");
            baglanti.Close();
            verileriGetir();

            txtVerileriniTemizle();
        }
        void baglan()
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
        }

        private void dgVeriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

