using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class KaizenModel
  {
    [BsonId]
    public string id { get; set; }
    // Người tạo
    public string user_create { get; set; }
    // Ngày tạo
    public long date_create { get; set; }
    // Ngày đánh giá
    public long date_status { get; set; }
    // Tiêu đề
    public string name { get; set; }
    // Nội dung
    public string content { get; set; }
    // Hình ảnh
    public List<string> images { get; set; }
    // Chủ đề
    public string type { get; set; }
    // Trạng thái
    public int status { get; set; }
    // Người thích
    public List<string> likes { get; set; }
    // Người không thích
    public List<string> hates { get; set; }
    // Bình luận
    public List<Comment> comments { get; set; }

    public class Comment
    {
      public string id { get; set; }
      public string user { get; set; }
      public string content { get; set; }
      public long date { get; set; }
      public bool pin { get; set; }
    }
  }
}