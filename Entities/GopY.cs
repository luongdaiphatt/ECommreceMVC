using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class GopY
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_gy"), BsonRepresentation(BsonType.String)]
        public string MaGY { get; set; }

        [BsonElement("ma_cd"), BsonRepresentation(BsonType.Int32)]
        public int MaCD { get; set; }

        [BsonElement("noi_dung"), BsonRepresentation(BsonType.String)]
        public string NoiDung { get; set; }

        [BsonElement("ngay_gy"), BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayGY { get; set; }

        [BsonElement("ho_ten"), BsonRepresentation(BsonType.String)]
        public string? HoTen { get; set; }

        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public string? Email { get; set; }

        [BsonElement("dien_thoai"), BsonRepresentation(BsonType.String)]
        public string? DienThoai { get; set; }

        [BsonElement("can_tra_loi"), BsonRepresentation(BsonType.Boolean)]
        public bool CanTraLoi { get; set; }

        [BsonElement("tra_loi"), BsonRepresentation(BsonType.String)]
        public string? TraLoi { get; set; }

        [BsonElement("ngay_tl"), BsonRepresentation(BsonType.DateTime)]
        public DateTime? NgayTL { get; set; }
    }
}
