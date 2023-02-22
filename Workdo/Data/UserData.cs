using System.Threading.Tasks;
using Workdo.Models;

namespace Workdo.Data;

public class UserData
{
  private static UserModel UserDemo = new UserModel()
  {
    id = "0123456789",
    email = "admin@workdo.com",
    password = "admin@#",
    avatar = "https://avatars.dicebear.com/api/micah/happy.svg?background=pink",
    first_name = "Admin",
    last_name = "Workdo",
    session = "781e5e245d69b566979b86e28d23f2c7"
  };

  public static async Task<UserModel> Get(string session)
  {
    await Task.Delay(100);
    return UserDemo;
  }

  public static async Task<UserModel> Login(string username, string password)
  {
    await Task.Delay(100);
    return UserDemo;
  }
}
