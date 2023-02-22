using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class EducateCategoryModel
  {
    [BsonId]
    public string id { get; set; }
    // Tiêu đề
    public string name { get; set; }
    // Hình ảnh
    public string image { get; set; }
  }
}
