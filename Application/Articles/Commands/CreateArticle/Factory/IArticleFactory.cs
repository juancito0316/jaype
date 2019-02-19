using Domain.Articles;
using Domain.Categories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Articles.Commands.Factory
{
    interface IArticleFactory
    {
        Article Create(DateTime date, Category category, string content);
    }
}
