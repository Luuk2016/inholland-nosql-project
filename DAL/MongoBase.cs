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

        /*
        * Get a table
        * @param string table - the name of the table/collecton
        * @return List<T> - a list of the specified type
        */
        public List<T> GetTable<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var documents = collection.Find(new BsonDocument()).ToList();

            return documents;
        }

        /*
        * Get a record of the specified table by ID
        * @param string table - the name of the table/collecton
        * @param string id - the id of the record
        * @return T - an object of the specified type
        */
        public T GetRecordById<T>(string table, string id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));

            return collection.Find(filter).First();
        }

        /*
        * Insert a new record in the specified table/collection
        * @param string table - the name of the table/collecton
        * @param T record - an object
        */
        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        /*
        * Delete a record from the specified table by it's ID
        * @param string table - the name of the table/collecton
        * @param string id - the id of the record
        */
        public void DeleteRecordById<T>(string table, string id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));

            collection.DeleteOne(filter);
        }
    }
}
