using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class QuotesModel
  {
    [BsonId]
    public string id { get; set; }
    // Nội dung
    public string name { get; set; }
    // Tác giả
    public string author { get; set; }
    // Ngày tạo
    public long date { get; set; }
  }
}
