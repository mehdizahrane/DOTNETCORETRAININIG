using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreTraining.Models;
using CoreTraining.ViewModels;
namespace CoreTraining.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var articles = new List<Article>()
            {
                new Article() { Title = "Lorem ipsum.", Body="Lorem texte herehe here erehqsd ", Slug="lorem-ipsum", Publisher = new User(){slug="mehdi-zahrane"}, Category = new Category(){ Name="Lorem" } },
                new Article() { Title = "Lorem ipsum.", Body="Lorem texte herehe here erehqsd ", Slug="lorem-ipsum", Publisher = new User(){slug="mehdi-zahrane"}, Category = new Category(){ Name="Lorem" } },
                new Article() { Title = "Lorem ipsum.", Body="Lorem texte herehe here erehqsd ", Slug="lorem-ipsum", Publisher = new User(){slug="mehdi-zahrane"}, Category = new Category(){ Name="Lorem" } }

            };
            var vm = new HomeIndexViewModel(){
                Articles = articles
            };
            return View(vm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
