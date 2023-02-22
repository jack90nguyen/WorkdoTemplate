using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Workdo.Data;
using Workdo.Models;
using ClosedXML.Excel;

namespace Workdo.Helpers
{
  public class FileHelper
  {
    private static bool isMacOS = Environment.CurrentDirectory.Contains("/");

    /// <summary>
    /// Lưu file vào hosting
    /// </summary>
    public static async Task<string> SaveFileAsync(StreamContent inputStream, string fileName)
    {
      string folder = "upload\\";
      string filePath = Environment.CurrentDirectory + "\\wwwroot\\" + folder;

      if (isMacOS)
        filePath = filePath.Replace("\\", "/");

      if (!Directory.Exists(filePath))
        Directory.CreateDirectory(filePath);

      string format = new FileInfo(fileName.ToLower()).Extension;

      string rename = DateTime.Now.Ticks + format;

      string path = Path.Combine(filePath, rename);

      await using FileStream fs = new(path, FileMode.Create);
      await inputStream.CopyToAsync(fs);
      fs.Dispose();
      inputStream.Dispose();

      return $"/{folder.Replace("\\", "/")}/{rename}";
    }
  }
}
