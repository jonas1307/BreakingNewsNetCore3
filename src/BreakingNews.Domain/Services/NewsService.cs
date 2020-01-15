using BreakingNews.Domain.Entities;
using BreakingNews.Domain.Interfaces.Repository;
using BreakingNews.Domain.Interfaces.Services;

namespace BreakingNews.Domain.Services
{
    public class NewsService : ServiceBase<News>, INewsService
    {
        public NewsService(IRepositoryBase<News> repository) : base(repository)
        { }
    }
}