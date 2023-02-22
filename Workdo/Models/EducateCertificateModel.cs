using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class EducateCertificateModel
  {
    [BsonId]
    public string id { get; set; }
    // Tiêu đề
    public string name { get; set; }
    // Hình ảnh
    public string image { get; set; }
    // Màu text
    public string color { get; set; }
    // Ngày tạo
    public long date { get; set; }
    // Ghim
    public bool pin { get; set; }
  }
}
