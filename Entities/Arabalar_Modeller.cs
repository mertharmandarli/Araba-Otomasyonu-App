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
    public class Arabalar_Modeller
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("Araç_Model")]
        public string Araç_Model { get; set; }

        [BsonElement("Araç_Marka")]
        public ObjectId  Marka_ID{ get; set; }
    }
}
