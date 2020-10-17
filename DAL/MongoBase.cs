using System;
using System.Collections.Generic;
using System.Linq;
using Model;
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
        * @return T - an object of the specified type or NULL
        */
        public T GetRecordById<T>(string table, string id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));

            return collection.Find(filter).FirstOrDefault();
        }

        /*
        * Get a record of the specified table by key
        * @param string table - the name of the table/collecton
        * @param string key - the key (column)
        * @param string value - the value
        * @return T - an object of the specified type or NULL
        */
        public T GetRecordByKeyValue<T>(string table, string key, string value)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(key, value);

            return collection.Find(filter).FirstOrDefault();
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

        /*
        * Get a record from a table by using the specified filter
        * @param string table - the name of the table/collecton
        * @param FilterDefinition<T> filter - the filter
        * @return T - an object of the specified type or NULL
        */
        public T GetRecordByFilter<T>(string table, FilterDefinition<T> filter)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(filter).FirstOrDefault();
        }

        /*
        * Update a record
        * @param string table - the name of the table/collecton
        * @param string id - the id of the record that should be updated
        */
        public void UpdateRecord<T>(string table, string id, T record)
        {
            var collection = db.GetCollection<T>(table);

            var result = collection.ReplaceOne(
                new BsonDocument("_id", ObjectId.Parse(id)),
                record
            );
        }
    }
}
