using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class EducateLearnedModel
  {
    [BsonId]
    public string id { get; set; }
    // ID khóa học
    public string course { get; set; }
    public string course_name { get; set; }
    // ID người học
    public string user { get; set; }
    // ID giảng viên
    public string teacher { get; set; }
    // Trạng thái: 1. đang học, 2. Cấp chứng chỉ, 3. Không đạt
    public int status { get; set; }
    // Ngày bắt đầu học
    public long date { get; set; }
    // Bài giảng
    public List<Lesson> lessons { get; set; }
    // Chứng chỉ: nền
    public string certificate_image { get; set; }
    // Chứng chỉ: màu
    public string certificate_color { get; set; }
    // Chứng chỉ: ngày cấp
    public long certificate_date { get; set; }

    public class Lesson
    {
      public string id { get; set; }
      public long date { get; set; }
      public bool done { get; set; }
      public bool pass { get; set; }
      public int type { get; set; }
    }
  }
}