using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp1.Entities
{
    [BsonIgnoreExtraElements]
    public class Arabalar_Markalar
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("Araç_Marka")]
        public string Araç_Marka { get; set; }
    }
}
