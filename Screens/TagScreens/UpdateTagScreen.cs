using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
  public class UpdateTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Nova tag");
      Console.WriteLine("=====================");
      Console.WriteLine("Id: ");
      var id = Console.ReadLine();

      Console.WriteLine("Name: ");
      var name = Console.ReadLine();

      Console.WriteLine("Slug: ");
      var slug = Console.ReadLine();
      Update(new Tag
      {
        Id = int.Parse(id),
        Name = name,
        Slug = slug,
      });
      Console.ReadKey();
      MenuTagScreen.Load();
    }


    private static void Update(Tag tag)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);
        repository.Update(tag);
        Console.WriteLine("Tag atualizada com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível atualizar a tag");
        Console.WriteLine(ex.Message);
      }
    }
  }
}