using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class WorkPlanModel
  {
    [BsonId]
    public string id { get; set; }

    /// <summary>Tiêu đề</summary>
    public string name { get; set; }

    /// <summary>Mô tả</summary>
    public string detail { get; set; }

    /// <summary>Trạng thái: 1. Đang diễn ra, 2. Đã hoàn thành</summary>
    public int status { get; set; }

    /// <summary>Chế độ bảo mật</summary>
    public bool is_private { get; set; }

    /// <summary>Lưu trữ</summary>
    public bool is_hide { get; set; }

    /// <summary>Người tạo</summary>
    public string creator { get; set; }

    /// <summary>Ngày bắt đầu</summary>
    public long date_start { get; set; }

    /// <summary>Ngày kết thúc</summary>
    public long date_end { get; set; }

    /// <summary>Thành viên dự án. role = 1: quản lý, 2: thành viên</summary>
    public List<Member> members { get; set; }

    /// <summary>Nhãn công việc</summary>
    public List<Label> labels { get; set; }

    /// <summary>Nhóm công việc</summary>
    public List<Section> sections { get; set; }

    /// <summary>Cột mốc kế hoạch</summary>
    public List<Timeline> timelines { get; set; }




    /// <summary>
    /// Thành viên
    /// </summary>
    public class Member
    {
      /// <summary>User ID</summary>
      public string id { get; set; }

      /// <summary>Quyền</summary>
      public int role { get; set; }
    }

    /// <summary>
    /// Nhãn công việc
    /// </summary>
    public class Label
    {
      /// <summary>ID</summary>
      public string id { get; set; }

      /// <summary>Tên nhãn</summary>
      public string name { get; set; }

      /// <summary>Màu</summary>
      public string color { get; set; }
    }

    /// <summary>
    /// Nhóm công việc
    /// </summary>
    public class Section
    {
      /// <summary>ID</summary>
      public string id { get; set; }

      /// <summary>Tên nhóm</summary>
      public string name { get; set; }

      /// <summary>Thứ tự</summary>
      public int pos { get; set; }
    }

    /// <summary>
    /// Cột mốc kế hoạch
    /// </summary> 
    public class Timeline
    {
      /// <summary>ID</summary>
      public string id { get; set; }

      /// <summary>Tên cột mốt</summary>
      public string name { get; set; }

      /// <summary>Thời gian</summary>
      public long date { get; set; }

      /// <summary>Gửi thông báo</summary>
      public bool is_noti { get; set; }
    }

    /// <summary>
    /// Công việc
    /// </summary> 
    public class Task
    {
      [BsonId]
      public string id { get; set; }

      /// <summary>Tên công việc</summary>
      public string name { get; set; }

      /// <summary>Mô tả</summary>
      public string detail { get; set; }

      /// <summary>Trạng thái</summary>
      public int status { get; set; }

      /// <summary>Độ ưu tiên</summary>
      public int priority { get; set; }

      /// <summary>Thứ tự sắp xếp</summary>
      public int pos { get; set; }

      /// <summary>Ngày bắt đầu</summary>
      public long date_start { get; set; }

      /// <summary>Ngày kết thúc</summary>
      public long date_end { get; set; }

      /// <summary>Ngày hoàn thành</summary>
      public long date_done { get; set; }

      /// <summary>Kế hoạch</summary>
      public string plan_id { get; set; }

      /// <summary>Nhóm công việc</summary>
      public string section_id { get; set; }

      /// <summary>Công việc chính</summary>
      public string parent_id { get; set; }

      /// <summary>Số công việc phụ</summary>
      public int sub_task { get; set; }

      /// <summary>Số lượng bình luận</summary>
      public int comment { get; set; }

      /// <summary>Nhãn công việc</summary>
      public List<string> labels { get; set; }

      /// <summary>Người tham gia. role = 1: người nhận xét, 2: người thực hiện</summary>
      public List<Member> members { get; set; }
    }

    /// <summary>
    /// Bình luận
    /// </summary> 
    public class Comment
    {
      [BsonId]
      public string id { get; set; }

      /// <summary>Mô tả</summary>
      public string detail { get; set; }

      /// <summary>Ngày tạo</summary>
      public long date { get; set; }

      /// <summary>Kế hoạch</summary>
      public string plan_id { get; set; }

      /// <summary>Công việc</summary>
      public string task_id { get; set; }

      /// <summary>Người tạo</summary>
      public string user_id { get; set; }
    }

    /// <summary>
    /// Báo cáo thống kê
    /// </summary>
    public class Report
    {
      [BsonId]
      public string id { get; set; }

      /// <summary>Số lượng công việc</summary>
      public int total { get; set; }

      /// <summary>Công việc hoàn thành</summary>
      public int done { get; set; }

      /// <summary>Công việc đúng hạn</summary>
      public int ontime { get; set; }

      /// <summary>Công việc trễ hạn</summary>
      public int late { get; set; }

      /// <summary>Thông số khác</summary>
      public int other { get; set; }
    }
  }
}