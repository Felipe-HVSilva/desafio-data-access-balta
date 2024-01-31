using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public static class CreatePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Novo usuário");
      Console.WriteLine("====================");

      Console.WriteLine("ID da Categoria: ");
      var category = int.Parse(Console.ReadLine()!);

      Console.WriteLine("Id do autor (user):");
      var autor = int.Parse(Console.ReadLine()!);

      Console.WriteLine("Titulo: ");
      var title = Console.ReadLine();

      Console.WriteLine("Resumo: ");
      var summary = Console.ReadLine();

      Console.WriteLine("Corpo do texto");
      var body = Console.ReadLine();


      Create(new Post
      {
        CategoryId = category,
        AuthorId = autor,
        Title = title,
        Summary = summary,
        Body = body,
        Slug = "",
        CreateDate = DateTime.UtcNow,
        LastUpdateDate = DateTime.UtcNow
      });
      Console.ReadKey();
      MenuPostScreen.Load();
    }

    public static void Create(Post post)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Create(post);
        Console.WriteLine("Post criado com sucesso");

      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível criar esse usuário com sucesso!");
        Console.WriteLine(ex.Message);
      }
    }
  }
}