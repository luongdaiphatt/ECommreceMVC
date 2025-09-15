using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class BanBe
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_bb"), BsonRepresentation(BsonType.Int32)]
        public int MaBB { get; set; }

        [BsonElement("ma_kh"), BsonRepresentation(BsonType.String)]
        public string? MaKH { get; set; }

        [BsonElement("ma_hh"), BsonRepresentation(BsonType.Int32)]
        public int MaHH { get; set; }

        [BsonElement("ho_ten"), BsonRepresentation(BsonType.String)]
        public string? HoTen { get; set; }

        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public string? Email { get; set; }

        [BsonElement("ngay_gui"), BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayGui { get; set; }

        [BsonElement("ghi_chu"), BsonRepresentation(BsonType.String)]
        public string? GhiChu { get; set; }
    }

}
