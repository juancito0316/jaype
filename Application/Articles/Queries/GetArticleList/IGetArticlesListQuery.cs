using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Articles.Queries.GetArticleList
{
    public interface IGetArticlesListQuery
    {
        List<ArticlesListModel> Execute();
    }
}
