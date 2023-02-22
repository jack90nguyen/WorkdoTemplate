using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class CompanyModel
  {
    [BsonId]
    public string id { get; set; }

    public bool delete { get; set; }

    public string name { get; set; }

    public string phone { get; set; }

    public string address { get; set; }

    public string admin_id { get; set; }

    public bool status { get; set; }

    public long create_date { get; set; }

    public Module module { get; set; }

    public Todolist todolist { get; set; }

    public List<Kaizen> kaizen { get; set; }

    /// <summary>Danh mục cửa hàng</summary>
    public List<StaticModel> gift_category { get; set; }

    public class Module
    {
      public bool okrs { get; set; }
      public bool todo { get; set; }
      public bool kaizen { get; set; }
      public bool educate { get; set; }
    }

    public class Todolist
    {
      // Thời gian nộp HH:mm
      public string time_checkin { get; set; }
      // Thời gian checkout HH:mm
      public string time_checkout { get; set; }
      // Thời gian tự động xác nhận
      public string time_confirm { get; set; }
    }

    public class Kaizen
    {
      public string id { get; set; }
      public string name { get; set; }
      public string image { get; set; }
      public string parent { get; set; }
    }
  }
}