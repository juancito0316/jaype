using Domain.Categories;
using Domain.Common;
using System;

namespace Domain.Articles
{
    public class Article : IEntity
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }

        public void Select() {
            throw new NotImplementedException();
        }
    }
}
