using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class TrangWeb
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_tw"), BsonRepresentation(BsonType.Int32)]
        public int MaTW { get; set; }

        [BsonElement("ten_tw"), BsonRepresentation(BsonType.String)]
        public string TenTW { get; set; }

        [BsonElement("url"), BsonRepresentation(BsonType.String)]
        public string Url { get; set; }
    }
}
