using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class PostRepository : Repository<Post>
  {
    private readonly SqlConnection _connection;
    public PostRepository(SqlConnection connection) : base(connection)
    => _connection = connection;

    public IEnumerable<(Post post, string categoryName)> GetPostWithCategory()
    {
      var query = @"
        SELECT 
          [Post].[Title], [Category].[Name]
        FROM
          [Post]
          RIGHT JOIN [Category] ON [Category].[Id] = [Post].[CategoryId]";

      return _connection.Query<Post, string, (Post, string)>(query, (post, categoryName) => (post, categoryName), splitOn: "Name");
    }

    public List<Post> GetWithTags()
    {
      var query = @"
        SELECT
            p.*,
            t.*
        FROM
            [Post] p
          LEFT JOIN
            [PostTag] pt ON pt.[PostId] = p.[Id]
          LEFT JOIN
            [Tag] t ON pt.[TagId] = t.[Id]";

      var posts = new List<Post>();

      var items = _connection.Query<Post, Tag, Post>(query, (post, tag) =>
      {
        var pst = posts.FirstOrDefault(x => x.Id == post.Id);
        {
          if (pst == null)
          {
            pst = post;
            if (tag != null)
              pst.Tags.Add(tag);
            posts.Add(pst);
          }
          else
          {
            pst.Tags.Add(tag);
          };
          return post;
        }
      }, splitOn: "Id");

      return posts;
    }
  }
}