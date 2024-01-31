using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class CategoryRepository : Repository<Category>
  {
    private readonly SqlConnection _connection;

    public CategoryRepository(SqlConnection connection) : base(connection)
    => _connection = connection;


    public IEnumerable<(Category category, int postCount)> GetCategoryWithPostCount()
    {
      var query = @"
        SELECT [Category].[Name], COUNT(CategoryId) AS PostCount
        FROM [Category]
        LEFT JOIN [Post] ON [Category].[Id] = [Post].[CategoryId]
        GROUP BY [Category].[Name]
      ";

      return _connection.Query<Category, int, (Category, int)>(query, (category, postCount)
       => (category, postCount), splitOn: "PostCount");
    }

    public IEnumerable<Post> GetPostsByCategoryId(int categoryId)
    {
      var query = @"
                SELECT *
                FROM [Post]
                WHERE [CategoryId] = @CategoryId
            ";

      return _connection.Query<Post>(query, new { CategoryId = categoryId });

    }
  }
}