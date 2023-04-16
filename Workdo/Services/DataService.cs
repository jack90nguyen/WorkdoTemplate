using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace Workdo.Services;

public class DataService
{
  #region MongoDB

  /// <summary>
  /// Kết nối MongoDB
  /// </summary>
  public static IMongoDatabase DbConnect()
  {
    var client = new MongoClient();
    return client.GetDatabase("crm_haviland");
  }

  /// <summary>
  /// Tạo bản clone cho data theo Model
  /// </summary>
  /// <param name="model">Dữ liệu cần nhân bản</param>
  public static T Clone<T>(T model)
  {
    var serialized = JsonConvert.SerializeObject(model);
    return JsonConvert.DeserializeObject<T>(serialized);
  }

  #endregion


  #region Tạo ID ngẫu nhiên

  private static readonly Random random = new Random();
  private static readonly string Characters = "0123456789abcdefghijklmnopqrstuvwxyz";

  /// <summary>
  /// Hàm tạo ID mặc định: 3[Date] + 3[Random]
  /// </summary>
  public static string RandomId()
  {
    return RandomId(6);
  }

  /// <summary>
  /// Hàm tạo ID tùy chọn độ dài
  /// </summary>
  public static string RandomId(int length)
  {
    var date = DateTime.Today;
    var result = new StringBuilder();
    result.Append(Characters[date.Year - 2020]);
    result.Append(Characters[date.Month]);
    result.Append(Characters[date.Day]);
    for (int i = 0; i < length - 3; i++)
      result.Append(Characters[RandomInt(0, 35)]);
    return result.ToString().ToUpper();
  }

  // <summary>
  /// Tạo một số ngẫu nhiên từ min đến max
  /// </summary>
  public static int RandomInt(int min, int max)
  {
    return random.Next(min, max + 1);
  }

  #endregion
}
