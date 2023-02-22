using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class UserModel
  {
    [BsonId]
    public string id { get; set; }

    public bool delete { get; set; }

    public bool active { get; set; }

    public string email { get; set; }

    public string phone { get; set; }

    public string first_name { get; set; }

    public string last_name { get; set; }

    public string avatar { get; set; }

    public string password { get; set; }

    public string session { get; set; }

    public string online_page { get; set; }

    public long online { get; set; }

    public long create_date { get; set; }

    public bool is_admin { get; set; }

    /// <summary>Không thống kê</summary>
    public bool no_report { get; set; }

    /// <summary>Tự checkin OKRs</summary>
    public bool okr_checkin { get; set; }

    /// <summary>Không nhận thông báo đổi quà</summary>
    public bool noti_store { get; set; } = true;

    /// <summary>Quyền trong công ty: 1. Admin, 2. QLHT, 3. Nhân viên</summary>
    public int role { get; set; }

    /// <summary>Chức danh: 1. quản lý, 2. phó quản lý, 3. nhân viên</summary>
    public int title { get; set; }

    /// <summary>Chức danh: tên chức danh trong phòng ban</summary>
    public string title_name { get; set; }

    /// <summary>Danh sách công ty trực thuộc</summary>
    public List<Company> companys { get; set; }

    /// <summary>Quyền theo chức năng</summary>
    public RoleManage role_manage { get; set; }

    /// <summary>Danh sách ID phòng ban trực thuộc</summary>
    public List<string> departments_id { get; set; }

    /// <summary>Danh sách ID phòng ban trong đội nhóm</summary>
    public List<string> teams_id { get; set; }

    /// <summary>Danh sách tên phòng ban trực thuộc</summary>
    public string departments_name { get; set; }

    /// <summary>Phòng ban mặc định cho các bộ lọc</summary>
    public string department_default { get; set; }

    /// <summary>Tổng số sao cá nhân</summary>
    public int star_total { get; set; }

    /// <summary>Tổng số sao được cấp</summary>
    public int star_distribute { get; set; }

    /// <summary>Tổng số sao nhận được</summary>
    public int star_receive { get; set; }

    /// <summary>Tổng sao cho đi</summary>
    public int star_give { get; set; }

    /// <summary>Trang mặc định khi vào phần mềm</summary>
    public string page_default { get; set; }

    /// <summary>Không thống kê: OKRs</summary>
    public bool no_report_okr { get; set; }

    /// <summary>Không thống kê: CFRs</summary>
    public bool no_report_cfr { get; set; }

    /// <summary>Không thống kê: Todolist</summary>
    public bool no_report_todolist { get; set; }

    /// <summary>Không thống kê: Kaizen</summary>
    public bool no_report_kaizen { get; set; }

    /// <summary>Không thống kê: Thành tựu</summary>
    public bool no_report_achievement { get; set; }

    /// <summary>Các kế hoạch đã ghim</summary>
    public List<string> plans_pin { get; set; }

    /// <summary>Các kế hoạch đã lưu trữ</summary>
    public List<string> plans_hide { get; set; }


    public class Company
    {
      public string id { get; set; }
      public string name { get; set; }
    }

    public class RoleManage
    {
      // Cơ cấu
      public bool system { get; set; }
      // OKRs - CFRs
      public bool okrs { get; set; }
      // Kaizen
      public bool kaizen { get; set; }
      // Đào tạo
      public bool educate { get; set; }
      // Đổi quà
      public bool store { get; set; }
      // Tiện ích
      public bool other { get; set; }
    }

    public string FullName
    {
      get { return $"{first_name} {last_name}"; }
    }
  }


  /// <summary>Thông tin tài khoản</summary>
  public class MemberModel
  {
    public string id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string avatar { get; set; }
  }
}
