using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Articles.Queries.GetArticleDetail
{
    public interface IGetArticleDetail
    {
        ArticleDetailModel Execute(int id);
    }
}
