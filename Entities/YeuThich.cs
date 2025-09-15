using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class YeuThich
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_yt"), BsonRepresentation(BsonType.Int32)]
        public int MaYT { get; set; }

        [BsonElement("ma_kh"), BsonRepresentation(BsonType.String)]
        public string MaKH { get; set; }

        [BsonElement("ma_hh"), BsonRepresentation(BsonType.Int32)]
        public int MaHH { get; set; }

        [BsonElement("ngay_yt"), BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayYT { get; set; }
    }
}
