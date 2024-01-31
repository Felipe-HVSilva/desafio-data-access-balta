using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens {
  public class ListPostScreen {
    public static void Load() {
      List();
    }
    public static  void List() {
      var repository = new Repository<Post>(Database.Connection); 
      var posts = repository.Get();

      Console.WriteLine("Quantidade de Posts: " + posts.Count());
  }
  }
}