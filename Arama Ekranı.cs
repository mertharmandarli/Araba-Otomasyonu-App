using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        IMongoCollection<Arabalar> arabaCollection;
        IMongoCollection<Arabalar_Markalar> markaCollection;
        IMongoCollection<Arabalar_Modeller> modelCollection;

        public Form2()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Araba_Al_Sat_MongoDBCalisma");
            arabaCollection = database.GetCollection<Arabalar>("Arabalar");
            markaCollection = database.GetCollection<Arabalar_Markalar>("ArabalarMarka");
            modelCollection = database.GetCollection<Arabalar_Modeller>("ArabalarModeller");
            InitializeComponent();
        }

        private void clearFields()
        {
            txtAracPlaka.Clear();
            txtFiyatMaks.Clear();
            txtFiyatMin.Clear();
            cmbAracMarka.SelectedIndex = -1;
            cmbAracModel.SelectedIndex = -1;
        }

        ArabaOperations arabaOperations = new ArabaOperations();

        private void Form2_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Araba_Al_Sat_MongoDBCalisma");

            #region Tüm Tabloyu Getirme
            List<Arabalar> arabalar = arabaOperations.GetAllArabalar();
            dataGridView1.DataSource = arabalar;
            #endregion

            #region Marka Bilgilerini ComboBox'a Getirme

            var markalar = markaCollection.Find(new BsonDocument()).ToList();

            cmbAracMarka.DataSource = markalar;
            cmbAracMarka.DisplayMember = "Araç_Marka";
            cmbAracMarka.ValueMember = "_id";

            #endregion

            #region Model Bilgilerini ComboBox'a Getirme

            var modeller = modelCollection.Find(new BsonDocument()).ToList();


            cmbAracModel.DataSource = modeller;
            cmbAracModel.DisplayMember = "Araç_Model";
            cmbAracModel.ValueMember = "_id";

            #endregion
        }

        private void cmbAracMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAracMarka.SelectedIndex == -1 || cmbAracMarka.SelectedValue == null) return;

            ObjectId secilenMarkaID;

            try
            {
                if (cmbAracMarka.SelectedValue is ObjectId)
                {
                    secilenMarkaID = (ObjectId)cmbAracMarka.SelectedValue;
                }
                else
                {
                    if (!ObjectId.TryParse(cmbAracMarka.SelectedValue.ToString(), out secilenMarkaID))
                        return;
                }

                var filtre = Builders<Arabalar_Modeller>.Filter.Eq(x => x.Marka_ID, secilenMarkaID);

                var filtrelenmisModeller = modelCollection.Find(filtre).ToList();


                cmbAracModel.DataSource = filtrelenmisModeller;
                cmbAracModel.DisplayMember = "Araç_Model";
                cmbAracModel.ValueMember = "_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model bilgileri getirilirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            decimal minFiyat = 0;
            decimal maxFiyat = 0;

            decimal.TryParse(txtFiyatMin.Text, out minFiyat);
            decimal.TryParse(txtFiyatMaks.Text, out maxFiyat);

            if (string.IsNullOrEmpty(txtFiyatMaks.Text))
            {
                maxFiyat = decimal.MaxValue;
            }

            var builder = Builders<Arabalar>.Filter;

            var filtre = builder.Gte(x => x.Araç_Fiyat, minFiyat) & builder.Lte(x => x.Araç_Fiyat, maxFiyat);

            var sonucListesi = arabaCollection.Find(filtre).ToList();

            dataGridView1.DataSource = sonucListesi;
        }
    }
}
