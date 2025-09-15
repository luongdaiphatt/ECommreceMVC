using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class HangHoa
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_hh"), BsonRepresentation(BsonType.Int32)]
        public int MaHH { get; set; }

        [BsonElement("ten_hh"), BsonRepresentation(BsonType.String)]
        public string? TenHH { get; set; }

        [BsonElement("ten_alias"), BsonRepresentation(BsonType.String)]
        public string? TenAlias { get; set; }

        [BsonElement("ma_loai"), BsonRepresentation(BsonType.Int32)]
        public int MaLoai { get; set; }

        [BsonElement("mo_ta_don_vi"), BsonRepresentation(BsonType.String)]
        public string? MoTaDonVi { get; set; }

        [BsonElement("don_gia"), BsonRepresentation(BsonType.Double)]
        public double? DonGia { get; set; }

        [BsonElement("hinh"), BsonRepresentation(BsonType.String)]
        public string? Hinh { get; set; }

        [BsonElement("ngay_sx"), BsonRepresentation(BsonType.DateTime)]
        public DateTime NgaySX { get; set; }

        [BsonElement("giam_gia"), BsonRepresentation(BsonType.Double)]
        public double GiamGia { get; set; }

        [BsonElement("so_lan_xem"), BsonRepresentation(BsonType.Int32)]
        public int SoLanXem { get; set; }

        [BsonElement("mo_ta"), BsonRepresentation(BsonType.String)]
        public string? MoTa { get; set; }

        [BsonElement("ma_ncc"), BsonRepresentation(BsonType.String)]
        public string? MaNCC { get; set; }
    }
}
