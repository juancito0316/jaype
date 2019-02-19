using Application.Articles.Queries.GetArticleList;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Articles
{
    public class ArticlesController : Controller
    {
        readonly IGetArticlesListQuery _articlesListQuery;

        public ArticlesController(IGetArticlesListQuery articlesListQuery) {
            this._articlesListQuery = articlesListQuery;
        }

        public IActionResult Index() {
            var articles = _articlesListQuery.Execute();
            return View("ArticleIndex", articles);
        }
    }
}
