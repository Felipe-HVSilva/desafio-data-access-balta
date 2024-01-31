using Blog.Repositories;

namespace Blog.Screens.TagScreens {
  public class ListTagWithPost {
    public static void Load() {
      Console.WriteLine("Quantidade de post por Tag");
      Console.WriteLine("==============================");
      ListTag();
    }

    public static void ListTag() {
      var repository = new TagRepository(Database.Connection);
      var tags = repository.GetTagsWithPostCount();

      foreach (var tag in tags) {
        Console.WriteLine(tag.tag.Slug + tag.postCount);
         Console.WriteLine("");
      }
    }
  }
}