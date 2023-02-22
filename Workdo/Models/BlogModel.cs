using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class BlogModel
  {
    [BsonId]
    public string id { get; set; }

    /// <summary>Tiêu đề</summary>
    public string name { get; set; }

    /// <summary>Mô tả</summary>
    public string desc { get; set; }

    /// <summary>Liên kết</summary>
    public string link { get; set; }

    /// <summary>Hình ảnh</summary>
    public string image { get; set; }

    /// <summary>Nội dung</summary>
    public string content { get; set; }

    /// <summary>Phòng ban</summary>
    public string department { get; set; }

    /// <summary>Ngày tạo</summary>
    public long date { get; set; }

    /// <summary>Pin</summary>
    public bool pin { get; set; }

    /// <summary>Tin tiêu điểm</summary>
    public bool is_all { get; set; }
  }
}
