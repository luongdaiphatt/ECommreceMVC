using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceMVC.Entities
{
    public class NhaCungCap
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ma_ncc"), BsonRepresentation(BsonType.String)]
        public string MaNCC { get; set; }

        [BsonElement("ten_ncc"), BsonRepresentation(BsonType.String)]
        public string? TenNCC { get; set; }

        [BsonElement("dia_chi"), BsonRepresentation(BsonType.String)]
        public string? DiaChi { get; set; }

        [BsonElement("dien_thoai"), BsonRepresentation(BsonType.String)]
        public string? DienThoai { get; set; }
    }
}
