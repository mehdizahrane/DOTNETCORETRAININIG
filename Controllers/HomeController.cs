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
                new Article() { Title = "Lorem ipsum.", Caption = "images/pic01.jpg", Body="Lorem texte herehe here erehqsd ", Slug="lorem-ipsum", Publisher = new User(){slug="mehdi-zahrane"}, Category = new Category(){ Name="Lorem" } },
                new Article() { Title = "Lorem ipsum.", Caption = "images/pic05.jpg", Body="Lorem texte herehe here erehqsd ", Slug="lorem-ipsum", Publisher = new User(){slug="mehdi-zahrane"}, Category = new Category(){ Name="Lorem" } },
                new Article() { Title = "Lorem ipsum.", Caption = "images/pic02.jpg", Body="Lorem texte herehe here erehqsd ", Slug="lorem-ipsum", Publisher = new User(){slug="mehdi-zahrane"}, Category = new Category(){ Name="Lorem" } }

            };
            var vm = new HomeIndexViewModel(){
                Articles = articles
            };
            return View(vm);
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
