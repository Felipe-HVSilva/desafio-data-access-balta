namespace Blog.Screens.PostScreens
{
  public static class MenuPostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de posts");
      Console.WriteLine("========================");
      Console.WriteLine();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Cadastar");
      Console.WriteLine("2 - Listar");
      Console.WriteLine("3 - Listar post com categoria");
      Console.WriteLine("4 - Listar post com tag");

      var option = short.Parse(Console.ReadLine()!);

      switch (option)
      {
        case 1:
          CreatePostScreen.Load();
          break;
        case 2:
          ListPostScreen.Load();
          break;
        case 3:
          ListPostWithCategory.Load();
          break;
        case 4:
          ListPostWithTag.Load();
          break;
        default: Load(); break;
      }
    }
  }
}