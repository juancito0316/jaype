using Application.Interfaces.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Network
{
    public class NotificationService : INotificationService {

        public NotificationService() {

        }

        public void NotifyArticleOcurred(int articleId) {
            throw new NotImplementedException();
        }

        public void NotifyCommentOcurred(int articleId, int commentId) {
            throw new NotImplementedException();
        }
    }
}
