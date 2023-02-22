using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class TodolistModel
  {
    [BsonId]
    public string id { get; set; }

    /// <summary>Ngày của todolist</summary>
    public long date { get; set; }

    /// <summary>Người tạo</summary>
    public string user_create { get; set; }

    /// <summary>Ngày tạo</summary>
    public long date_create { get; set; }

    /// <summary>Ngày checkin</summary>
    public long date_checkin { get; set; }

    /// <summary>Ngày checkout</summary>
    public long date_checkout { get; set; }

    /// <summary>Ngày xác nhận</summary>
    public long date_confirm { get; set; }

    /// <summary>Tình trạng checkin</summary>
    public bool ontime_checkin { get; set; }

    /// <summary>Tình trạng checkout</summary>
    public bool ontime_checkout { get; set; }

    /// <summary>Ngày nghỉ/ngày thường</summary>
    public bool day_off { get; set; }

    /// <summary>Người xác nhận  = auto → tự động xác nhận</summary>
    public string user_confirm { get; set; }

    /// <summary>Trạng thái: 1. Mới tạo, 2. Đã checkin, 3. Đã checkout</summary>
    public int status { get; set; }

    /// <summary>Điểm để xếp hạng</summary>
    public int point { get; set; }

    /// <summary>Công việc: số lượng</summary>
    public int total { get; set; }

    /// <summary>Công việc: hoàn thành</summary>
    public int done { get; set; }

    /// <summary>Danh sách công việc -> bỏ</summary>
    public List<Todo> todos { get; set; }

    // <summary>
    /// Công việc trong Todolist
    /// </summary>
    public class Todo
    {
      [BsonId]
      public string id { get; set; }

      /// <summary>Todolist ID</summary>
      public string todolist { get; set; }

      /// <summary>User ID</summary>
      public string user { get; set; }

      /// <summary> Tên công việc</summary>
      public string name { get; set; }

      /// <summary> Chi tiết</summary>
      public string detail { get; set; }

      /// <summary> Kết quả</summary>
      public string result { get; set; }

      /// <summary>Ngày của Todolist</summary>
      public long date { get; set; }

      /// <summary> Thời gian bắt đầu</summary>
      public string start { get; set; }

      /// <summary> Thời gian kết thúc</summary>
      public string end { get; set; }

      /// <summary> Phân loại</summary>
      public int type { get; set; }

      /// <summary> Độ ưu tiên</summary>
      public int level { get; set; }

      /// <summary> Trạng thái</summary>
      public int status { get; set; }

      /// <summary> Đã được xác nhận</summary>
      public bool confirm { get; set; }

      /// <summary>Liên kết với công việc trong kế hoạch</summary>
      public string plan_task { get; set; }
    }
  }
}