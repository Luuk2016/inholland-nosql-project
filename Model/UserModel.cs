using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class UserModel
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string type { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string location { get; set; }
        public string hashedPassword { get; set; }
        public string salt { get; set; }
    }
}
