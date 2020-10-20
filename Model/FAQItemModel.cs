using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class FAQItemModel 
    {
        [BsonId]
        public ObjectId id { get; set; }
        public FAQItemType type { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
    }
}
