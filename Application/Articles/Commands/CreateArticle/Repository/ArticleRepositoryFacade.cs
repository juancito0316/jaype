using System;
using System.Collections.Generic;
using System.Text;
using Application.Interfaces.Persistance;
using Domain.Articles;
using Domain.Categories;
using Domain.Users;

namespace Application.Articles.Commands.CreateArticle.Repository
{
    public class ArticleRepositoryFacade : IArticleRepositoryFacade {

        readonly IArticleRepository _articleRepository;
        readonly ICategoryRepository _categoryRepository;

        public ArticleRepositoryFacade(IArticleRepository articleRepository, ICategoryRepository categoryRepository) {
            this._articleRepository = articleRepository;
            this._categoryRepository = categoryRepository;
        }
        public void AddArticle(Article article) {
            _articleRepository.Add(article);
        }

        public Category GetCategory(int categoryId) {
            return _categoryRepository.Get(categoryId);
        }
        
    }
}
