using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostTagScreen {
  public class LinkPostTagScreen {
    public static void Load() {
      Console.WriteLine("Vincular Post/Tag");
      Console.WriteLine("Id do Post: ");
      var postId = int.Parse(Console.ReadLine());

      Console.WriteLine("Id da Tag: ");
      var tagId = int.Parse(Console.ReadLine());

      Create(new PostTag{
        PostId = postId,
        TagId = tagId
      });
    }

    public static void Create(PostTag postTag) {
      var repository = new Repository<PostTag>(Database.Connection);

      repository.Create(postTag);
    }
  }
}