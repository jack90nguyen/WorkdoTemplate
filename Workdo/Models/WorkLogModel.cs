using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class WorkLogModel
  {
    [BsonId]
    public string id { get; set; }

    /// <summary>Tên hành động</summary>
    public string name { get; set; }

    /// <summary>Chi tiết hành động</summary>
    public string detail { get; set; }

    /// <summary>Thời gian thực hiện</summary>
    public long date { get; set; }

    /// <summary>Kế hoạch</summary>
    public string plan { get; set; }

    /// <summary>Công việc</summary>
    public string task { get; set; }

    /// <summary>Người thực hiện</summary>
    public MemberModel user { get; set; }
  }
}