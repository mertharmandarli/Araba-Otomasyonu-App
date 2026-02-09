using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private void clearFields()
        {
            txtAracFiyat.Clear();
            txtAracHasarKaydı.Clear();
            txtAracMarka.Clear();
            txtAracModel.Clear();
            txtAracPlaka.Clear();
            txtAracYılı.Clear();
            txtIlanDurumu.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }

        ArabaOperations arabaOperations = new ArabaOperations();
        IMongoCollection<Arabalar> arabalarCollection;
        IMongoCollection<Arabalar_Markalar> arabalarMarkalarCollection;
        IMongoCollection<Arabalar_Modeller> arabalarModellerCollection;

        private void btnFind_Click(object sender, EventArgs e)
        {
            Form2 aramaEkranı = new Form2();
            aramaEkranı.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var araba = new Arabalar()
            {
                Araç_Fiyat = Decimal128.Parse(txtAracFiyat.Text),
                Araç_Hasar_Kaydı = txtAracHasarKaydı.Text,
                Araç_Marka = txtAracMarka.Text,
                Araç_Model = txtAracModel.Text,
                Araç_Plaka = txtAracPlaka.Text,
                Araç_Yılı = Int32.Parse(txtAracYılı.Text),
                İlan_Durum = txtIlanDurumu.Text
            };

            arabaOperations.AddAraba(araba);
            MessageBox.Show("Araç başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
            clearFields();
        }
        private void GetAll()
        {
            List<Arabalar> arabalar = arabaOperations.GetAllArabalar();
            dataGridView1.DataSource = arabalar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Araba_Al_Sat_MongoDBCalisma");
            arabalarCollection = database.GetCollection<Arabalar>("Arabalar");
            arabalarMarkalarCollection = database.GetCollection<Arabalar_Markalar>("Arabalar_Markalar");
            arabalarModellerCollection = database.GetCollection<Arabalar_Modeller>("Arabalar_Modeller");

            GetAll();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetAll();
            clearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string plaka = txtAracPlaka.Text;

            var updatedAraba = new Arabalar()
            {
                Araç_Fiyat = Decimal128.Parse(txtAracFiyat.Text),
                Araç_Hasar_Kaydı = txtAracHasarKaydı.Text,
                Araç_Marka = txtAracMarka.Text,
                Araç_Model = txtAracModel.Text,
                Araç_Plaka = plaka,
                Araç_Yılı = Int32.Parse(txtAracYılı.Text),
                İlan_Durum = txtIlanDurumu.Text
            };

            arabaOperations.UpdateAraba(plaka, updatedAraba);

            MessageBox.Show("Araç başarıyla güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
            clearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string plaka = txtAracPlaka.Text;

            arabaOperations.DeleteAraba(plaka);

            MessageBox.Show("Araç başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAll();
            clearFields();
        }

        private void btnPlakaCagir_Click(object sender, EventArgs e)
        {
            string arananPlaka = txtAracPlaka.Text.Trim();

            if (string.IsNullOrEmpty(arananPlaka))
            {
                MessageBox.Show("Lütfen bir plaka girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var bulunanArac = arabalarCollection.Find(x => x.Araç_Plaka == arananPlaka).FirstOrDefault();

                if (bulunanArac != null)
                {
                    // --- VERİLERİ KUTULARA DOLDUR ---

                    txtAracFiyat.Text = bulunanArac.Araç_Fiyat.ToString();
                    txtAracModel.Text = bulunanArac.Araç_Model.ToString();
                    txtAracHasarKaydı.Text = bulunanArac.Araç_Hasar_Kaydı;
                    txtIlanDurumu.Text = bulunanArac.İlan_Durum;
                    txtAracMarka.Text = bulunanArac.Araç_Marka;
                    txtAracYılı.Text = bulunanArac.Araç_Model;
                  
                    // --- GÜNCELLEME İÇİN ID SAKLAMA (Çok Önemli) ---
                    // Aracı bulduk, peki ya kullanıcı değiştirip "Güncelle" derse?
                    // Hangi ID'yi güncelleyeceğini bilmek için ID'yi Plaka kutusunun "Tag" özelliğine gizliyoruz.
                    txtAracPlaka.Tag = bulunanArac._Id;

                    MessageBox.Show("Araç bilgileri getirildi.");
                }
                else
                {
                    MessageBox.Show("Bu plakaya ait araç bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
