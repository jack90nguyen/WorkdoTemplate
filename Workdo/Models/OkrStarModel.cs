using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class OkrStarModel
  {
    [BsonId]
    public string id { get; set; }

    /// <summary>ID người tạo</summary>
    public string user { get; set; }

    /// <summary>Số sao cấp</summary>
    public int star { get; set; }

    /// <summary>Loại ví: 1. Ghi nhận, 2. Cá nhân</summary>
    public int wallet { get; set; }

    /// <summary>Ngày tạo</summary>
    public long create_date { get; set; }

    /// <summary>Người tạo</summary>
    public string create_id { get; set; }
  }
}
