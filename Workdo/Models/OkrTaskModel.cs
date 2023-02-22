using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class OkrTaskModel
  {
    [BsonId]
    public string id { get; set; }

    public string name { get; set; }
    // Chu kỳ
    public string cycle { get; set; }
    // Người tạo
    public string user { get; set; }
    // OkrId
    public string okr { get; set; }
    // KrId
    public string kr { get; set; }
    // Bắt đầu
    public long start { get; set; }
    // Kết thúc
    public long end { get; set; }
    // Link kế hoạch
    public string link { get; set; }
    // Kết quả hàng động
    public string result { get; set; }
    // Trạng thái
    public int status { get; set; }
  }
}
