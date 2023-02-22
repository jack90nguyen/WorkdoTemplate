using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class GiftBannerModel
  {
    [BsonId]
    public string id { get; set; }
    // Tiêu đề
    public string name { get; set; }
    // Hình ảnh
    public string image { get; set; }
    // Sản phẩm
    public string products { get; set; }
    // Ghim lên đầu
    public bool pin { get; set; }
    // Phòng ban
    public string department { get; set; }
  }
}
