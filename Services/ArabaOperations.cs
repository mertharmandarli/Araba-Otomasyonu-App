using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.ObjectModel;

namespace WindowsFormsApp1.Services
{
    public class ArabaOperations
    {
        public void AddAraba(Arabalar araba)
        {
            var connection = new MongoDBConnections();

            var carCollection = connection.GetCarCollection();

            var document = new BsonDocument
            {
                {"Araç_Fiyat", araba.Araç_Fiyat},
                {"Araç_Hasar_Kaydı", araba.Araç_Hasar_Kaydı },
                {"Araç_Marka", araba.Araç_Marka},
                {"Araç_Model", araba.Araç_Model},
                {"Araç_Plaka", araba.Araç_Plaka},
                {"Araç_Yılı", araba.Araç_Yılı},
                {"İlan_Durum", araba.İlan_Durum}
            };

            carCollection.InsertOne(document);
        }
        
        public List<Arabalar> GetAllArabalar()
        {
            var connection = new MongoDBConnections();
            var carCollection = connection.GetCarCollection();
            var arabalarList = new List<Arabalar>();
            var documents = carCollection.Find(new BsonDocument()).ToList();
            foreach (var doc in documents)
            {
                var araba = new Arabalar
                {
                    _Id = doc.GetValue("_id").AsObjectId,
                    Araç_Fiyat = doc.GetValue("Araç_Fiyat").AsDecimal128,
                    Araç_Hasar_Kaydı = doc.GetValue("Araç_Hasar_Kaydı").AsString,
                    Araç_Marka = doc.GetValue("Araç_Marka").AsString,
                    Araç_Model = doc.GetValue("Araç_Model").AsString,
                    Araç_Plaka = doc.GetValue("Araç_Plaka").AsString,
                    Araç_Yılı = doc.GetValue("Araç_Yılı").AsInt32,
                    İlan_Durum = doc.GetValue("İlan_Durum").AsString
                };
                arabalarList.Add(araba);
            }

            return arabalarList;
        }

        public void DeleteAraba(string plaka)
        {
            var connection = new MongoDBConnections();
            var carCollection = connection.GetCarCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("Araç_Plaka", plaka);
            carCollection.DeleteOne(filter);
        }

        public void UpdateAraba(string plaka, Arabalar updatedAraba)
        {
            var connection = new MongoDBConnections();
            var carCollection = connection.GetCarCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("Araç_Plaka", updatedAraba.Araç_Plaka);

            var update = Builders<BsonDocument>.Update
                .Set("Araç_Fiyat", updatedAraba.Araç_Fiyat)
                .Set("Araç_Hasar_Kaydı", updatedAraba.Araç_Hasar_Kaydı)
                .Set("Araç_Marka", updatedAraba.Araç_Marka)
                .Set("Araç_Model", updatedAraba.Araç_Model)
                .Set("Araç_Yılı", updatedAraba.Araç_Yılı)
                .Set("İlan_Durum", updatedAraba.İlan_Durum);

            var result = carCollection.UpdateOne(filter, update);
        }
    }
}
