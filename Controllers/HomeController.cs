using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreTraining.Models;
using CoreTraining.ViewModels;
using CoreTraining.Contexts;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
namespace CoreTraining.Controllers
{
    public class HomeController : Controller
    {
        private readonly CodingClubDbContext _context;
        public HomeController(CodingClubDbContext context)
        {
            this._context = context;
        }
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
                if(_context.Users.Any(x => x.Username.Equals(username) && x.Password.Equals(password)))
                {
                        var user = _context.Users.SingleOrDefault(x => x.Username.Equals(username) && x.Password.Equals(password));
                        HttpContext.Session.SetInt32();
                }
                else
                {
                    IDictionary<String, String> errors = new Dictionary<String,String>()
                    {
                        { "invalid" , "Invalid Username or password." }
                    };
                    ViewData["errors"] = errors;
                    return View("Login");
                }
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
