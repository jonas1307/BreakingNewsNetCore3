using System;

namespace BreakingNews.Domain.Entities
{
    public class News : BaseEntity
    {
        public new long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public bool IsPublished { get; set; }
        public string FriendlyUrl { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
