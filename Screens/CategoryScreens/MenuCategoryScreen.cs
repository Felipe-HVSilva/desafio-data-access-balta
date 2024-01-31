namespace Blog.Screens.CategoryScreens
{
  public static class MenuCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de categorias");
      Console.WriteLine("========================");
      Console.WriteLine();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Cadastar");
      Console.WriteLine("2 - Listar");
      Console.WriteLine("3 - Atualizar");
      Console.WriteLine("4 - Excluir");
      Console.WriteLine("5 - Listar categorias com quantidade de post ");
      Console.WriteLine("6 - Listar posts de uma categoria");

      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          CreateCategoryScreen.Load();
          break;
        case 2:
          ListCategoryScreen.Load();
          break;
        case 3:
          UpdateCategoryScreen.Load();
          break;
        case 4:
          DeleteCategoryScreen.Load();
          break;
        case 5:
          ListCategoriesWithPostCount.Load();
          break;
        case 6:
          ListCategoriesWithPost.Load();
          break;
        default: Load(); break;
      }
    }
  }
}