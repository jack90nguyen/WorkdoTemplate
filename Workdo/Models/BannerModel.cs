using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class BannerModel
  {
    [BsonId]
    public string id { get; set; }

    /// <summary>Tiêu đề</summary>
    public string name { get; set; }

    /// <summary>Liên kết</summary>
    public string link { get; set; }

    /// <summary>Hình ảnh</summary>
    public string image { get; set; }

    /// <summary>Phòng ban</summary>
    public string department { get; set; }

    /// <summary>Ghim lên đầu</summary>
    public bool pin { get; set; }

    /// <summary>Ngày tạo</summary>
    public long date { get; set; }

    /// <summary>Thứ tự</summary>
    public int pos { get; set; }

    /// <summary>Trang hiển thị</summary>
    public Dictionary<string, string> pages { get; set; }
  }
}
