using Application.Articles.Commands.CreateArticle.Repository;
using Application.Articles.Commands.Factory;
using Application.Interfaces.Infrastructure;
using Application.Interfaces.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Articles.Commands.CreateArticle
{
    class CreateArticleCommand : ICreateArticleCommand {

        readonly IArticleRepositoryFacade _repositories;
        readonly IArticleFactory _factory;
        readonly INotificationService _notifications;
        readonly IUnitOfWork _unitOfWork;

        public CreateArticleCommand(IArticleRepositoryFacade repositories, IArticleFactory factory) {
            this._repositories = repositories;
            this._factory = factory;
        }

        public void Execute(CreateArticleModel model) {

            var date = DateTime.UtcNow;
            var category = _repositories.GetCategory(model.CategoryId);

            var article = _factory.Create(date, category, model.Content);

            _unitOfWork.Save();

            _notifications.NotifyArticleOcurred(article.Id);
        }
    }
}
