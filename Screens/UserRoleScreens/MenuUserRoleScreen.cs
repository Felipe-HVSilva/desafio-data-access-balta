using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserRoleScreens
{
  public class MenuUserRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Vincular usuário/perfil");
      Console.WriteLine("=======================");

      Console.WriteLine("Id do usuário");
      var userId = int.Parse(Console.ReadLine());

      Console.WriteLine("Id do Perfil");
      var roleId = int.Parse(Console.ReadLine());

      Create(new UserRole
      {
        RoleId = roleId,
        UserId = userId
      });
    }

    public static void Create(UserRole userRole)
    {
      var repository = new Repository<UserRole>(Database.Connection);
      repository.Create(userRole);
    }
  }
}