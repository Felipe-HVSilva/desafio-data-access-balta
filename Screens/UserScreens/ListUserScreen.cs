using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
  public static class ListUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de usuários");
      Console.WriteLine("====================");
      List();

      Console.ReadKey();
      MenuUserScreens.Load();
    }

    public static void List()
    {
      try
      {
        var repository = new UserRepository(Database.Connection);
        var users = repository.GetWithRoles();
        foreach (var user in users)
        {
          foreach (var role in user.Roles)
          {
            Console.WriteLine($"{user.Name}, {user.Email}, {role.Name} ");
          }

        }

      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível listar esses usuários");
        Console.WriteLine(ex);
      }
    }
  }
}