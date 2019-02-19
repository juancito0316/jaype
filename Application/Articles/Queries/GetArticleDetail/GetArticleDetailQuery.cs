using Application.Interfaces.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Articles.Queries.GetArticleDetail
{
    public class GetArticleDetailQuery : IGetArticleDetail {

        readonly IArticleRepository _repository;

        public GetArticleDetailQuery(IArticleRepository repository) {
            this._repository = repository;
        }

        public ArticleDetailModel Execute(int id) {

            var article = _repository.Get(id);
            return  new ArticleDetailModel() {
                Id = article.Id,
                Category = article.Category.Name,
                Name = article.Name,
                Content = article.Content
            };
        }
    }
}
