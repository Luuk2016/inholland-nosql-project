using System;
using Model.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class TicketModel
    {
        [BsonId]
        public ObjectId id { get; set; }
        public DateTime DateTimeReported { get; set; }
        public string Subject { get; set; }
        public TicketType Type { get; set; }
        public UserModel User { get; set; }
        public TicketPriority Priority { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
