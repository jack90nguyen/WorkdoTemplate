using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class EducateExamModel
  {
    [BsonId]
    public string id { get; set; }
    // ID khóa học
    public string course { get; set; }
    // Tên khóa học
    public string course_name { get; set; }
    // ID bài thi
    public string lesson { get; set; }
    // ID bài thi
    public string lesson_name { get; set; }
    // ID kỳ học
    public string learned { get; set; }
    // ID người học
    public string user { get; set; }
    // ID giảng viên
    public string teacher { get; set; }
    // Loại bài thi
    public int type { get; set; }
    // Mức điểm bài thi
    public int point_exam { get; set; }
    // Mức điểm đạt
    public int point_pass { get; set; }
    // Mức điểm tối đa
    public int point_max { get; set; }
    // Chấm bài hay chưa
    public bool check { get; set; }
    // Nhận xét
    public string comment { get; set; }
    // Thời gian thi
    public long date { get; set; }
    // Câu hỏi
    public List<Question> questions { get; set; }

    public class Question
    {
      public string id { get; set; }
      // Nội dung câu hỏi
      public string content { get; set; }
      // Đáp án câu hỏi
      public string answer { get; set; }
      // Nhận xét
      public string comment { get; set; }
      // Số điểm chấm
      public int point_exam { get; set; }
      // Số điểm tối đa
      public int point_max { get; set; }
    }
  }
}