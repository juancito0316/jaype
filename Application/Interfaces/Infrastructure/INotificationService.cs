using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Infrastructure
{
    public interface INotificationService
    {
        void NotifyCommentOcurred(int articleId, int commentId);
        void NotifyArticleOcurred(int articleId);
    }
}
