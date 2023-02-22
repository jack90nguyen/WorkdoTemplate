using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class GiftProductModel
  {
    [BsonId]
    public string id { get; set; }
    // Tên sản phẩm
    public string name { get; set; }
    // Hình ảnh
    public string image { get; set; }
    // Mô tả
    public string description { get; set; }
    // Giá bán
    public int price_list { get; set; }
    // Giá khuyến mãi
    public int price_sale { get; set; }
    // Số lượng đã đổi
    public int sold { get; set; }
    // Danh mục
    public int category { get; set; }
    // Hiển thị
    public bool show { get; set; }
    // Phòng ban
    public string department { get; set; }
  }
}