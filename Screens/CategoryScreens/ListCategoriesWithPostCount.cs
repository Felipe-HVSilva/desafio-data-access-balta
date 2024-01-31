using Blog.Repositories;

namespace Blog.Screens.CategoryScreens {
  public class ListCategoriesWithPostCount {
    public static void Load() {
      Console.Clear();
      Console.WriteLine("Categoiras");
      ListPost();
    }

    public static void ListPost() {
      var repository = new CategoryRepository(Database.Connection);

      var categories = repository.GetCategoryWithPostCount();

      foreach (var category in categories) {
        Console.WriteLine(category.category.Name + " " + category.postCount);
      }

    }
  }
}