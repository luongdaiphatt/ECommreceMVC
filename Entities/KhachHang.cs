using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class KhachHang
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_kh"), BsonRepresentation(BsonType.String)]
        public string MaKH { get; set; }

        [BsonElement("ho_ten"), BsonRepresentation(BsonType.String)]
        public string? HoTen { get; set; }

        [BsonElement("phai"), BsonRepresentation(BsonType.Boolean)]
        public bool? Phai { get; set; }

        [BsonElement("ngay_sinh"), BsonRepresentation(BsonType.DateTime)]
        public DateTime? NgaySinh { get; set; }

        [BsonElement("dia_chi"), BsonRepresentation(BsonType.String)]
        public string? DiaChi { get; set; }

        [BsonElement("dien_thoai"), BsonRepresentation(BsonType.String)]
        public string? DienThoai { get; set; }

        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public string? Email { get; set; }

        [BsonElement("tai_khoan"), BsonRepresentation(BsonType.String)]
        public string TaiKhoan { get; set; }

        [BsonElement("mat_khau"), BsonRepresentation(BsonType.String)]
        public string MatKhau { get; set; }

        [BsonElement("ma_so_thue"), BsonRepresentation(BsonType.String)]
        public string? MaSoThue { get; set; }

        [BsonElement("so_cmnd"), BsonRepresentation(BsonType.String)]
        public string? SoCMND { get; set; }

        [BsonElement("trang_thai"), BsonRepresentation(BsonType.Boolean)]
        public bool TrangThai { get; set; }
    }
}
