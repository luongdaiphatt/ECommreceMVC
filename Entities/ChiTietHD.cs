using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class ChiTietHD
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_ct"), BsonRepresentation(BsonType.Int32)]
        public int MaCT { get; set; }

        [BsonElement("ma_hd"), BsonRepresentation(BsonType.Int32)]
        public int MaHD { get; set; }

        [BsonElement("ma_hh"), BsonRepresentation(BsonType.Int32)]
        public int MaHH { get; set; }

        [BsonElement("don_gia"), BsonRepresentation(BsonType.Double)]
        public double DonGia { get; set; }

        [BsonElement("so_luong"), BsonRepresentation(BsonType.Int32)]
        public int SoLuong { get; set; }

        [BsonElement("giam_gia"), BsonRepresentation(BsonType.Double)]
        public double GiamGia { get; set; }
    }

}
