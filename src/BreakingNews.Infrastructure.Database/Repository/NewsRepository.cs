using BreakingNews.Domain.Entities;
using BreakingNews.Domain.Interfaces.Repository;

namespace BreakingNews.Infrastructure.Database.Repository
{
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    { }
}