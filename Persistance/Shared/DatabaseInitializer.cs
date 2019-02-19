//using System;
//using System.Linq;

//namespace Persistance.Shared {
//    public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext> {

//        public DatabaseInitializer() {
//        }

//        protected override void Seed(DatabaseContext context) {
//            base.Seed(context);

//            CreateCategories(context);
//            CreateArticle(context);

//        }

//        private void CreateArticle(DatabaseContext context) {
//            var categories = context.Categories.ToList();
//            context.Articles.Add(new Domain.Articles.Article() {
//                Name = "Welcome",
//                Category = categories[0],
//                DateCreated = DateTime.UtcNow
//            });

//            context.SaveChanges();
//        }

//        private void CreateCategories(DatabaseContext context) {
//            context.Categories.Add(new Domain.Categories.Category() {
//                Name = "Miscellaneous"
//            });
//            context.Categories.Add(new Domain.Categories.Category() {
//                Name = "Programming"
//            });
//            context.Categories.Add(new Domain.Categories.Category() {
//                Name = "Games"
//            });
//            context.Categories.Add(new Domain.Categories.Category() {
//                Name = "Sports"
//            });

//            context.SaveChanges();
//        }
//    }
//}