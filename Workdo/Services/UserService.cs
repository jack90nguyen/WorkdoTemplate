using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using Workdo.Data;
using Workdo.Models;

namespace Workdo.Services
{
  public class UserService
  {
    /// <summary>
    /// Chuyển UserModel thành MemberModel
    /// </summary>
    public static MemberModel ConvertToMember(UserModel user)
    {
      return new MemberModel()
      {
        id = user.id,
        name = user.FullName,
        email = user.email,
        avatar = user.avatar,
      };
    }

    /// <summary>
    /// Lấy 1 tài khoản trong danh sách tài khoản theo ID
    /// </summary>
    public static UserModel GetUser(List<UserModel> list, string userId)
    {
      var user = list.SingleOrDefault(x => x.id == userId);
      if (user != null)
        return user;
      else
        return new UserModel()
        {
          //id = userId,
          last_name = "Tài khoản đã xóa",
          avatar = "/images/avatar.png"
        };
    }
  }
}