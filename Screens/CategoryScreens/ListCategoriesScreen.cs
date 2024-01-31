using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
  public static class ListCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de categorias");
      Console.WriteLine("=====================");
      List();
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    private static void List()
    {
      var repository = new Repository<Category>(Database.Connection);
      var tags = repository.Get();
      foreach (var item in tags)
      {
        Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
      }
    }
  }
}