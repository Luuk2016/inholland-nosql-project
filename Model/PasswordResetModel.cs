using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class PasswordResetModel
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string email { get; set; }
        public string token { get; set; }
        public bool used { get; set; }
    }
}
