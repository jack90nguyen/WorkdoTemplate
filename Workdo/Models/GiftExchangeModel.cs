using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class GiftExchangeModel
  {
    [BsonId]
    public string id { get; set; }
    // Thời gian mua
    public long date { get; set; }
    // Người mua
    public string user_buy { get; set; }
    // Người nhận
    public string user_give { get; set; }
    // Ghi chú cho người nhận
    public string note { get; set; }
    // Người nhận xem quà chưa
    public bool view { get; set; }
    // Trạng thái: 1: Chờ xử lý, 2: Đã duyệt, 3: Đã hủy
    public int status { get; set; }
    // Id sản phẩm
    public string product { get; set; }
    // Tên sản phẩm
    public string name { get; set; }
    // Hình ảnh
    public string image { get; set; }
    // Giá mua
    public int price { get; set; }
    // Số lượng
    public int quantity { get; set; }
    // Mua/giỏ hàng
    public bool buy { get; set; }
  }
}