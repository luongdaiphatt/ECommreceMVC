using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class QuangCao
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_qc"), BsonRepresentation(BsonType.Int32)]
        public int MaQC { get; set; }

        [BsonElement("ten_qc"), BsonRepresentation(BsonType.String)]
        public string? TenQC { get; set; }

        [BsonElement("hinh"), BsonRepresentation(BsonType.String)]
        public string? Hinh { get; set; }

        [BsonElement("link"), BsonRepresentation(BsonType.String)]
        public string? Link { get; set; }
    }

}
