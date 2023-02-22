using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class OkrConfigModel
  {
    [BsonId]
    public string id { get; set; }

    public List<Cycle> cycles { get; set; }

    public List<Suggest> suggests { get; set; }

    public List<Evaluate> evaluates { get; set; }


    public class Cycle
    {
      public string id { get; set; }
      public string name { get; set; }
      public long start { get; set; }
      public long end { get; set; }
      public bool done { get; set; }
    }

    public class Suggest
    {
      public string id { get; set; }
      public string name { get; set; }
    }

    public class Evaluate
    {
      public string id { get; set; }
      public string name { get; set; }
      public int star { get; set; }
      public int type { get; set; } // 1. Phản hồi | 2. Ghi nhận
      public bool special { get; set; } // Ghi nhận dặt biệt
    }
  }
}
