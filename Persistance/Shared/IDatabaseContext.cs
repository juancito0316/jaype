using Domain.Articles;
using Domain.Categories;
using Domain.Comments;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Shared
{
    public interface IDatabaseContext
    {
        DbSet<Article> Articles { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<T> Set<T>() where T : class, IEntity;

        void Save();
    }
}
