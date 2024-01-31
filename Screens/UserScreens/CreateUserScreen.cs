using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
  public static class CreateUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Novo usuário");
      Console.WriteLine("====================");

      Console.WriteLine("Name: ");
      var name = Console.ReadLine();

      Console.WriteLine("E-mail:");
      var email = Console.ReadLine();

      Console.WriteLine("Biografia: ");
      var bio = Console.ReadLine();

      Console.WriteLine("Password: ");
      var password = Console.ReadLine();

      Console.WriteLine("Slug");
      var slug = Console.ReadLine();

      Create(new User { Name = name, Email = email, PasswordHash = password, Slug = slug, Image = "https://", Bio = bio });
      Console.ReadKey();
      MenuUserScreens.Load();
    }

    public static void Create(User user)
    {
      try
      {
        var repository = new UserRepository(Database.Connection);
        repository.Create(user);
        Console.WriteLine("Usuário criado com sucesso!");

      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível criar esse usuário com sucesso!");
        Console.WriteLine(ex.Message);
      }
    }
  }
}