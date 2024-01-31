using Blog.Models;
using Blog.Repositories;
using Blog.Screens.CategoryScreens;

namespace Blog.Screens.CategoryScreens
{
  public class DeleteCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir uma categoria");
      Console.WriteLine("=====================");
      Console.WriteLine("Qual id da Categoria que deseja excluir? ");
      var id = int.Parse(Console.ReadLine());

      Delete(id);
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }


    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Tag deletada com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível deletar a tag");
        Console.WriteLine(ex.Message);
      }
    }
  }
}