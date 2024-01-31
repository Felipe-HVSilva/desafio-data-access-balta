using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
  public class UpdateCategoryScreen
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
      Update(new Category
      {
        Id = int.Parse(id),
        Name = name,
        Slug = slug,
      });
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }


    private static void Update(Category category)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);
        repository.Update(category);
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