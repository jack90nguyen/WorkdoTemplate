using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class DepartmentModel
  {
    [BsonId]
    public string id { get; set; }

    public bool delete { get; set; }

    public string name { get; set; }

    public string parent { get; set; }
    // Chức danh quản lý
    public string manager { get; set; }
    // Chức danh phó quản lý
    public string deputy { get; set; }

    public int pos { get; set; }

    public List<string> members_id { get; set; }

    public List<MembersList> members_list { get; set; }


    public class MembersList
    {
      public string id { get; set; } // ID nhân viên
      public int role { get; set; } // 1: quản lý; 2: phó quản lý; 3: nhân viên
    }

    public class SelectList
    {
      public string id { get; set; }
      public string name { get; set; }
      public int level { get; set; }
    }
  }
}