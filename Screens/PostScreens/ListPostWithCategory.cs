using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public class ListPostWithCategory
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Posts");
      Console.WriteLine("===================");
      ListPost();
    }

    public static void ListPost()
    {
      var repository = new PostRepository(Database.Connection);

      var items = repository.GetPostWithCategory();

      foreach (var item in items)
      {
        Console.WriteLine(item.post.Title + " - " + item.categoryName);
      }
    }
  }
}