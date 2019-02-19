using Domain.Articles;
using Domain.Categories;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Articles.Commands.CreateArticle.Repository
{
    public interface IArticleRepositoryFacade
    {
        Category GetCategory(int categoryId);

        void AddArticle(Article article);
    }
}
