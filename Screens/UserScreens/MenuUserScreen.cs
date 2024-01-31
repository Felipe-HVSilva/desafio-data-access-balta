namespace Blog.Screens.UserScreens
{
  public static class MenuUserScreens
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de usuários");
      Console.WriteLine("========================");
      Console.WriteLine();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Cadastar");
      Console.WriteLine("2 - Listar");
      Console.WriteLine("3 - Atualizar");
      Console.WriteLine("4 - Excluir");

      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          CreateUserScreen.Load();
          break;
        case 2:
          ListUserScreen.Load();
          break;
        case 3:
          UpdateUserScreen.Load();
          break;
        case 4:
          //DeleteTagScreen.Load();
          break;
        default: Load(); break;
      }
    }
  }
}