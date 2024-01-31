using Blog.Screens.RoleScreens;

namespace Blog.Screens.RoleScreen
{
  public class MenuRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de perfil");
      Console.WriteLine("====================");
      Console.WriteLine("1 - Cadastrar");

      var option = int.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          CreateRoleScreen.Load();
          break;
        default:
          Load();
          break;
      }
    }


  }
}