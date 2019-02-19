using Application.Articles.Queries.GetArticleList;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Articles
{
    public class AboutController : Controller
    {
        
        public AboutController() {
        }

        public IActionResult Index() {
            return View("About");
        }
    }
}
