using Blog.Models;
using Microsoft.Data.SqlClient;
using Dapper;

namespace Blog.Repositories
{
    public class TagRepository : Repository<Tag>
    {
        private readonly SqlConnection _connection;
        public TagRepository(SqlConnection connection) : base(connection)
        => _connection = connection;

        public IEnumerable<(Tag tag, int postCount)> GetTagsWithPostCount()
        {
            var query = @"
                SELECT t.*, COUNT(pt.PostId) AS PostCount
                FROM [Tag] t
                LEFT JOIN PostTag pt ON t.Id = pt.TagId
                GROUP BY t.Id, t.Name, t.Slug";

            return _connection.Query<Tag, int, (Tag, int)>(query,
                (tag, postCount) => (tag, postCount),
                splitOn: "PostCount");
        }
    }
}
