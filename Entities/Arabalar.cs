using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Entities
{
    public class Arabalar
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]


        public ObjectId _Id { get; set; }

        public Decimal128 Araç_Fiyat { get; set; }
        public string Araç_Hasar_Kaydı { get; set; }
        public string Araç_Marka { get; set; }
        public string Araç_Model { get; set; }

        [BsonElement("Araç_Plaka")]
        public string Araç_Plaka { get; set; }
        
        public int Araç_Yılı { get; set; }
        public string İlan_Durum { get; set; }
    }
}
