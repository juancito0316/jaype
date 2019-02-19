using System;

namespace Application.Articles.Queries.GetArticleList {
    public class ArticlesListModel {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ContentSummary { get; set; }
    }
}