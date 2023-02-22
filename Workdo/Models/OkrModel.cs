using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class OkrModel
  {
    [BsonId]
    public string id { get; set; }

    public bool delete { get; set; }

    public string name { get; set; }
    // Chu kỳ
    public string cycle { get; set; }
    // Loại: 1. mở rộng, 2. Cam kết
    public int type { get; set; }
    // OKRs cấp trên
    public string parent { get; set; }
    // Độ tự tin
    public int confident { get; set; }
    // Ngày tạo
    public long date_create { get; set; }
    // Người tạo
    public string user_create { get; set; }
    // Lần checkin cuối cùng
    public long date_checkin { get; set; }
    // Lần checkin tiếp theo
    public long next_checkin { get; set; }
    // Quản lý checkin
    public string user_checkin { get; set; }
    // Trạng thái checkin: 1. Nháp, 2. Đã xác nhận, 3. Đã checkin
    public int status_checkin { get; set; }
    // Hoàn thành/Chưa
    public bool done { get; set; }
    // Tiến độ lần checkin trước
    public double progress_prev { get; set; }
    // Kết quả chính
    public List<KeyResult> key_results { get; set; }


    public class KeyResult
    {
      public string id { get; set; }
      public string name { get; set; }
      public double target { get; set; }
      public double result { get; set; }
      public double change { get; set; }
      public string unit { get; set; }
      public string link { get; set; }
      public int confident { get; set; }
      // OKRs liên kết chéo
      public List<CrossLink> cross_links { get; set; }
    }

    public class CrossLink
    {
      public string id { get; set; }
      public string okr { get; set; }
      public string user { get; set; }
    }
  }
}