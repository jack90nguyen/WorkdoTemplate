using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class EducateLessonModel
  {
    [BsonId]
    public string id { get; set; }
    // ID khóa học
    public string course { get; set; }
    // Loại bài học
    public int type { get; set; }
    // Tên bài
    public string name { get; set; }
    // Hình ảnh
    public string image { get; set; }
    // Thời lượng: phút
    public int time { get; set; }
    // Thứ tự
    public int pos { get; set; }
    // Nội dung
    public string content { get; set; }
    // Video youtube
    public string video { get; set; }
    // File đính kèm
    public string file { get; set; }
    // Mức điểm đạt
    public int point { get; set; }
    // Câu hỏi
    public List<Question> questions { get; set; }


    public class Question
    {
      public string id { get; set; }

      public string content { get; set; }

      public int point { get; set; }

      public List<Answer> answers { get; set; }


      public class Answer
      {
        public string id { get; set; }

        public string content { get; set; }

        public bool correct { get; set; }
      }
    }
  }
}
