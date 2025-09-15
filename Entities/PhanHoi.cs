using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class PhanHoi
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_ph"), BsonRepresentation(BsonType.Int32)]
        public int MaPH { get; set; }

        [BsonElement("ma_nv"), BsonRepresentation(BsonType.String)]
        public string? MaNV { get; set; }

        [BsonElement("noi_dung"), BsonRepresentation(BsonType.String)]
        public string NoiDung { get; set; }

        [BsonElement("ngay_ph"), BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayPH { get; set; }

        [BsonElement("ghi_chu"), BsonRepresentation(BsonType.String)]
        public string? GhiChu { get; set; }
    }
}
