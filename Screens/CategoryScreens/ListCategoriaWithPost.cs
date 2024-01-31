using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
  public class ListCategoriesWithPost
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Qual Id da categoria?");
      var id = int.Parse(Console.ReadLine());
      ListPost(id);
    }

    public static void ListPost(int id)
    {
      var repository = new CategoryRepository(Database.Connection);

      var posts = repository.GetPostsByCategoryId(id);

      foreach (var post in posts)
      {
        Console.WriteLine(post.Title);
      }

    }
  }
}