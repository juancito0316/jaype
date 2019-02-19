using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Articles.Commands
{
    interface ICreateArticleCommand
    {
        void Execute(CreateArticleModel model);
    }
}
