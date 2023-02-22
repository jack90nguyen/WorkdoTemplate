using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class AchievementModel
  {
    [BsonId]
    public string id { get; set; }
    // Người nhận
    public string user { get; set; }
    // Tiêu đề
    public string name { get; set; }
    // Mô tả
    public string desc { get; set; }
    // Loại: kaizen, cfrs, educate, todolist
    public string type { get; set; }
    // Số sao
    public int star { get; set; }
    // Ngày tạo
    public long date { get; set; }
    // Xem thành tựu hay chưa → Chưa thì hiện popup
    public bool view { get; set; }
  }
}
