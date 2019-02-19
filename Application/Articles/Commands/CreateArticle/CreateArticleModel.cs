using System;

namespace Application.Articles.Commands {
    public class CreateArticleModel {
        public int PostId { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public int CategoryId { get; set; }
        public string AttachmentUrl { get; set; }
    }
}