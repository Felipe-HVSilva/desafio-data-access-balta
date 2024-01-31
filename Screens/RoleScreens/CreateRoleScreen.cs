using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
  public class CreateRoleScreen
  {
    public static void Load()
    {
      Console.Clear();

      Console.WriteLine("Nome");
      var name = Console.ReadLine();

      Console.WriteLine();

      Console.WriteLine("Slug");
      var slug = Console.ReadLine();

      Create(new Role
      {
        Name = name,
        Slug = slug
      });
    }

    public static void Create(Role role)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);
        repository.Create(role);
        Console.WriteLine("Perfil cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Houve um erro ao cadastrar o perfil");
      }

    }
  }
}