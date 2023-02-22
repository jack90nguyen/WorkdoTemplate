using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class DayOffModel
  {
    [BsonId]
    public string id { get; set; }
    // Tên ngày nghỉ
    public string name { get; set; }
    // Ngày bắt đầu
    public long start { get; set; }
    // Ngày kết thúc
    public long end { get; set; }
    // Ngày tạo
    public long create { get; set; }
    // Lặp: 1. Một lần | 2. Hàng tuần
    public int loop { get; set; }
    // Lặp ngày trong tuần
    public Week loop_week { get; set; }

    public class Week
    {
      public bool mon { get; set; }
      public bool tue { get; set; }
      public bool wed { get; set; }
      public bool thu { get; set; }
      public bool fri { get; set; }
      public bool sat { get; set; }
      public bool sun { get; set; }
    }
  }
}
