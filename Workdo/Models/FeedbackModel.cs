using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class FeedbackModel
  {
    [BsonId]
    public string id { get; set; }

    /// <summary>Ngày tạo</summary>
    public long date { get; set; }

    /// <summary>Tiêu đề</summary>
    public string name { get; set; }

    /// <summary>Nội dung</summary>
    public string content { get; set; }

    /// <summary>Có cập nhật mới từ admin</summary>
    public bool new_admin { get; set; }

    /// <summary>Có cập nhật mới từ khách hàng</summary>
    public bool new_client { get; set; }

    /// <summary>Files đính kèm</summary>
    public List<string> files { get; set; }

    /// <summary>Trạng thái</summary>
    public int status { get; set; }

    /// <summary>Người tạo: ID</summary>
    public string user_id { get; set; }

    /// <summary>Người tạo: tên</summary>
    public string user_name { get; set; }

    /// <summary>Người tạo: avatar</summary>
    public string user_avatar { get; set; }

    /// <summary>Tên công ty / Chăm sóc khách hàng</summary>
    public string company_id { get; set; }

    /// <summary>Công ty: ID</summary>
    public string company_name { get; set; }

    /// <summary>Phản hồi</summary>
    public List<Comment> comments { get; set; }

    /// <summary>Ghi chú</summary>
    public List<Note> notes { get; set; }


    public class Note
    {
      public string id { get; set; }

      /// <summary>Ngày tạo</summary>
      public long date { get; set; }

      /// <summary>Nội dung</summary>
      public string content { get; set; }

      /// <summary>Files đính kèm</summary>
      public List<string> files { get; set; }

      /// <summary>Người tạo: ID</summary>
      public string user_id { get; set; }

      /// <summary>Người tạo: tên</summary>
      public string user_name { get; set; }

      /// <summary>Người tạo: avatar</summary>
      public string user_avatar { get; set; }
    }


    public class Comment
    {
      public string id { get; set; }

      /// <summary>Ngày tạo</summary>
      public long date { get; set; }

      /// <summary>Nội dung</summary>
      public string content { get; set; }

      /// <summary>Files đính kèm</summary>
      public List<string> files { get; set; }

      /// <summary>Người tạo: ID</summary>
      public string user_id { get; set; }

      /// <summary>Người tạo: tên</summary>
      public string user_name { get; set; }

      /// <summary>Người tạo: avatar</summary>
      public string user_avatar { get; set; }

      /// <summary>Admin hệ thống</summary>
      public bool user_admin { get; set; }

      /// <summary>Công ty: ID</summary>
      public string company_name { get; set; }
    }
  }
}
