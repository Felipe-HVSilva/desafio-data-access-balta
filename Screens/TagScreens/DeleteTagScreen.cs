using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
  public class DeleteTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir uma tag");
      Console.WriteLine("=====================");
      Console.WriteLine("Qual id da Tag que deseja excluir? ");
      var id = int.Parse(Console.ReadLine());

      Delete(id);
      Console.ReadKey();
      MenuTagScreen.Load();
    }


    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);
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