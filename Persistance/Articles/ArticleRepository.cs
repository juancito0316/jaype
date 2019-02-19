using Application.Interfaces.Persistance;
using Domain.Articles;
using Persistance.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance.Articles
{
    public class ArticleRepository : Repository<Article>, IArticleRepository {

        public ArticleRepository(IDatabaseContext database) : base(database) {
                
        }
    }
}
