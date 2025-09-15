using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class Loai
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_loai"), BsonRepresentation(BsonType.Int32)]
        public int MaLoai { get; set; }

        [BsonElement("ten_loai"), BsonRepresentation(BsonType.String)]
        public string? TenLoai { get; set; }

        [BsonElement("hinh"), BsonRepresentation(BsonType.String)]
        public string? Hinh { get; set; }
    }
}
