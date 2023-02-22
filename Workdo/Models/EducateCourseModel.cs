using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class EducateCourseModel
  {
    [BsonId]
    public string id { get; set; }
    // Tên khóa học
    public string name { get; set; }
    // Hình ảnh
    public string image { get; set; }
    // Mô tả
    public string content { get; set; }
    // Danh mục
    public List<string> category { get; set; }
    // Thời lượng
    public string time { get; set; }
    // Số bài học
    public int lesson { get; set; }
    // Số người học
    public int learned { get; set; }
    // Số người tốt nghiệp
    public int graduated { get; set; }
    // Hiển thị
    public bool show { get; set; }
    // Ngày tạo
    public long date { get; set; }
    // Người tạo
    public string creator { get; set; }
    // Giảng viên
    public string teacher { get; set; }
    // Đánh giá
    public List<Review> reviews { get; set; }
    // Người đã lưu khóa học
    public List<string> bookmarks { get; set; }


    public class Review
    {
      public string id { get; set; }
      public string user { get; set; }
      public int point { get; set; }
    }
  }
}
