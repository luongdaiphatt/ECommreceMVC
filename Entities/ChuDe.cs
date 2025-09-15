using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class ChuDe
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_cd"), BsonRepresentation(BsonType.Int32)]
        public int MaCD { get; set; }

        [BsonElement("ten_cd"), BsonRepresentation(BsonType.String)]
        public string? TenCD { get; set; }

        [BsonElement("ma_nv"), BsonRepresentation(BsonType.String)]
        public string? MaNV { get; set; }
    }
}
