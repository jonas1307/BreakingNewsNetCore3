using BreakingNews.Application.Interfaces;
using BreakingNews.Domain.Entities;
using BreakingNews.Domain.Interfaces.Services;

namespace BreakingNews.Application.AppServices
{
    public class NewsAppService : AppServiceBase<News>, INewsAppService
    {
        public NewsAppService(IServiceBase<News> service) : base(service)
        { }
    }
}
