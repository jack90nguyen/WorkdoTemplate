using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class OkrCfrModel
  {
    [BsonId]
    public string id { get; set; }

    /// <summary>Chu kỳ</summary>
    public string cycle { get; set; }

    /// <summary>Ngày tạo</summary>
    public long date_create { get; set; }

    /// <summary>Người tạo</summary>
    public string user_create { get; set; }

    /// <summary>Người nhận</summary>
    public string user_receive { get; set; }

    /// <summary>Loại: 2. Ghi nhận, 3. Tặng sao</summary>
    public int type { get; set; }

    /// <summary>Số sao</summary>
    public int star { get; set; }

    /// <summary>Id OKRs</summary>
    public string okr { get; set; }
    public string okr_name { get; set; }

    /// <summary>Nội dung</summary>
    public string content { get; set; }

    /// <summary>ID tiêu chí</summary>
    public string evaluate { get; set; }
    public string evaluate_name { get; set; }

    /// <summary>Ghi nhận dặt biệt</summary>
    public bool special { get; set; }

    /// <summary>Riêng tư</summary>
    public bool privacy { get; set; }

    /// <summary>Thả tim</summary>
    public bool like { get; set; }
  }
}