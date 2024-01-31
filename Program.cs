using Blog.Screens.CategoryScreens;
using Blog.Screens.PostScreens;
using Blog.Screens.PostTagScreen;
using Blog.Screens.RoleScreen;
using Blog.Screens.TagScreens;
using Blog.Screens.UserRoleScreens;
using Blog.Screens.UserScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
  class Program
  {
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";
    static void Main(string[] args)
    {
      Database.Connection = new SqlConnection(CONNECTION_STRING);
      Database.Connection.Open();
      Load();

      Database.Connection.Close();
      Console.ReadKey();
    }

    static void Load()
    {
      Console.Clear();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("=============================");
      Console.WriteLine();
      Console.WriteLine("1 - Gestão de usuário");
      Console.WriteLine("2 - Gestão de post");
      Console.WriteLine("3 - Gestão de Tag");
      Console.WriteLine("4 - Gestão de categoria");
      Console.WriteLine("5 - Gestão de perfil");
      Console.WriteLine("6 - Vincular perfil/usuário");
      Console.WriteLine("7 - Vincular post/tag");
      Console.WriteLine("8 - Relatórios");
      Console.WriteLine();
      Console.WriteLine();

      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          MenuUserScreens.Load();
          break;
        case 2:
          MenuPostScreen.Load();
          break;
        case 3:
          MenuTagScreen.Load();
          break;
        case 4:
          MenuCategoryScreen.Load();
          break;
        case 5:
          MenuRoleScreen.Load();
          break;
        case 6:
          MenuUserRoleScreen.Load();
          break;
        case 7:
          LinkPostTagScreen.Load();
          break;

      }


    }
  }
}
