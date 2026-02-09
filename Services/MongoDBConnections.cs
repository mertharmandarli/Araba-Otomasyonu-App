using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Services
{
    public class MongoDBConnections
    {
        private IMongoDatabase _database;

        public MongoDBConnections()
        {
            var client = new MongoClient("mongodb://localhost:27017/");
            _database = client.GetDatabase("Araba_Al_Sat_MongoDBCalisma");
        }

        public IMongoCollection<BsonDocument> GetCarCollection()
        {
            return _database.GetCollection<BsonDocument>("Arabalar");
        }
    }
}
