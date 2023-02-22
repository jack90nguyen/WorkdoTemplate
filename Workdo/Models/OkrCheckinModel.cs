using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class OkrCheckinModel
  {
    [BsonId]
    public string id { get; set; }
    // Chu kỳ
    public string cycle { get; set; }
    // Ngày tạo
    public long date_create { get; set; }
    // Người tạo
    public string user_create { get; set; }
    // Ngày hoàn tất check-in
    public long date_checkin { get; set; }
    // Trạng thái check in: 1. Đúng hạn, 2. Trễ hạn
    public int status_checkin { get; set; }
    // Người checkin
    public string user_checkin { get; set; }
    // Id OKRs
    public string okr { get; set; }
    // Độ tự tin
    public int confident { get; set; }
    // Tiến độ lần checkin trước
    public double progress_prev { get; set; }
    // Checkin nháp/Xác nhận
    public bool draft { get; set; }
    // Checkin xong/chưa
    public bool checkin { get; set; }
    // Checkin Kết quả chính
    public List<KeyResult> key_results { get; set; }
    // Phản hồi checkin
    public List<Feedback> feedbacks { get; set; }


    public class KeyResult
    {
      public string id { get; set; }
      public double result { get; set; }
      public double change { get; set; }
      public int confident { get; set; }
      public List<string> questions { get; set; }
      public string feedback { get; set; }
    }

    public class Feedback
    {
      public string id { get; set; }
      public string user { get; set; }
      public string content { get; set; }
      public string kr { get; set; }
      public long date { get; set; }
    }
  }
}