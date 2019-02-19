using Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Persistance
{
    public interface IArticleRepository : IRepository<Article> 
    {
    }
}
