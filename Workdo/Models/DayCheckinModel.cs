using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class DayCheckinModel
  {
    [BsonId]
    public string id { get; set; }
    // Chu kỳ
    public string cycle { get; set; }
    // OKR ID
    public string okr { get; set; }
    public string okr_name { get; set; }
    // Nhận viên checkin
    public string user_create { get; set; }
    // Quản lý checkin
    public string user_checkin { get; set; }
    // Ngày thực hiện check-in
    public long date_checkin { get; set; }
    // Trạng thái: 0. Chưa checkin, 1. Đúng hạn, 2. Trễ hạn
    public int status { get; set; }
  }
}