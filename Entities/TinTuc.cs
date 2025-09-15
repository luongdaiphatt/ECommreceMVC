using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class TinTuc
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_tt"), BsonRepresentation(BsonType.Int32)]
        public int MaTT { get; set; }

        [BsonElement("tieu_de"), BsonRepresentation(BsonType.String)]
        public string TieuDe { get; set; }

        [BsonElement("noi_dung"), BsonRepresentation(BsonType.String)]
        public string NoiDung { get; set; }

        [BsonElement("hinh"), BsonRepresentation(BsonType.String)]
        public string? Hinh { get; set; }

        [BsonElement("ngay_dang"), BsonRepresentation(BsonType.DateTime)]
        public DateTime NgayDang { get; set; }

        [BsonElement("ma_nv"), BsonRepresentation(BsonType.String)]
        public string MaNV { get; set; }
    }
}
