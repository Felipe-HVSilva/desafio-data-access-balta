namespace Blog.Screens.TagScreens
{
  public static class MenuTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de tags");
      Console.WriteLine("========================");
      Console.WriteLine();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Cadastar");
      Console.WriteLine("2 - Listar");
      Console.WriteLine("3 - Atualizar");
      Console.WriteLine("4 - Excluir");
      Console.WriteLine("5 - Listar tag com quantidade de post");

      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          CreateTagScreen.Load();
          break;
        case 2:
          ListTagScreen.Load();
          break;
        case 3:
          UpdateTagScreen.Load();
          break;
        case 4:
          DeleteTagScreen.Load();
          break;
        case 5:
          ListTagWithPost.Load();
          break;
        default: Load(); break;
      }
    }
  }
}