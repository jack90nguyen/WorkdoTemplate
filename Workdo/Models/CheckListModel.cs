using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class CheckListModel
  {
    [BsonId]
    public string id { get; set; }

    /// <summary>Ngày tạo</summary>
    public long date { get; set; }

    /// <summary>Người tạo</summary>
    public string user { get; set; }

    /// <summary>Tiêu đề</summary>
    public string name { get; set; }

    /// <summary>Mô tả</summary>
    public string detail { get; set; }
  }
}