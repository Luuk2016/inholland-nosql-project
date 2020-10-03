using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class MongoBase
    {
        private IMongoDatabase db;

        public MongoBase()
        {
            var client = new MongoClient("mongodb+srv://groep2db:ki-adi-muni@cluster0.injcs.azure.mongodb.net/test");
            db = client.GetDatabase("servicedesk");
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> GetTable<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var documents = collection.Find(new BsonDocument()).ToList();

            return documents;
        }
    }
}
