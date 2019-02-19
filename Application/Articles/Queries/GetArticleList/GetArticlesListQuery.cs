using Application.Articles.Commands.CreateArticle.Repository;
using Application.Interfaces.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Articles.Queries.GetArticleList
{
    public class GetArticlesListQuery : IGetArticlesListQuery {

        readonly IArticleRepository _repository;

        public GetArticlesListQuery(IArticleRepository repository) {
            this._repository = repository;
        }

        public List<ArticlesListModel> Execute() {
            var articles = _repository.GetAll()
                 .Select(p => new ArticlesListModel() {
                      Category = p.Category.Name,
                      Name = p.Name,
                      Id = p.Id,
                      Date = p.DateCreated,
                      ContentSummary = p.Content
                 });

            return articles.ToList();
        }
    }
}
