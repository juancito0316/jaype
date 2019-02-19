using Domain.Common;
using System;

namespace Domain.Comments
{
    public class Comment : IEntity
    {
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
