using System;
using System.Collections.Generic;
using System.Text;
using Domain.Articles;
using Domain.Categories;

namespace Application.Articles.Commands.Factory
{
    class ArticleFactory : IArticleFactory {

        public Article Create(DateTime date, Category category, string content) {

            var article = new Article();
            article.DateCreated = date;
            article.DateUpdated = date;
            article.Category = category;
            article.Content = content;

            return article;
        }
    }
}
