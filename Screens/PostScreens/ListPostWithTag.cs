using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public class ListPostWithTag
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista");
      ListWithTag();
    }

    public static void ListWithTag()
    {
      var repository = new PostRepository(Database.Connection);

      var items = repository.GetWithTags();


      foreach (var post in items)
      {
        foreach (var tag in post.Tags)
        {
          Console.WriteLine($"{post.Title}, {tag.Name}");
        }
      }
    }
  }
}