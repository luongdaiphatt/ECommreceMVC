using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class HoaDon
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_hd"), BsonRepresentation(BsonType.Int32)]
        public int MaHD { get; set; }

        [BsonElement("ma_kh"), BsonRepresentation(BsonType.String)]
        public string MaKH { get; set; }

        [BsonElement("ngay_hd"), BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayHD { get; set; }

        [BsonElement("trigia"), BsonRepresentation(BsonType.Double)]
        public double TriGia { get; set; }

        [BsonElement("da_thanh_toan"), BsonRepresentation(BsonType.Boolean)]
        public bool DaThanhToan { get; set; }

        [BsonElement("hinh_thuc_tt"), BsonRepresentation(BsonType.String)]
        public string? HinhThucTT { get; set; }

        [BsonElement("ngay_tt"), BsonRepresentation(BsonType.DateTime)]
        public DateTime? NgayTT { get; set; }

        [BsonElement("ghi_chu"), BsonRepresentation(BsonType.String)]
        public string? GhiChu { get; set; }
    }
}
