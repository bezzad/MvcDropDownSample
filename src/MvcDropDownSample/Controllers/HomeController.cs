using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDropDownSample.Models;

namespace MvcDropDownSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your test page.";


            var p = new ProductViewModel
            {
                Name = "Test Combo or Drop Down in MVC",
                Categories = new List<ProductCategory>()
                {
                    new ProductCategory() {CategoryId = 1, CategoryName = "Test Option 1"},
                    new ProductCategory() {CategoryId = 2, CategoryName = "Test Option 2"},
                    new ProductCategory() {CategoryId = 3, CategoryName = "Test Option 3"},
                    new ProductCategory() {CategoryId = 4, CategoryName = "Test Option 4"}
                }
            };

            return View(p);
        }

        [HttpPost]
        public ActionResult TestFilled(ProductViewModel model)
        {
            var p = new ProductViewModel
            {
                Name = "Test Combo or Drop Down in MVC",
                Categories = new List<ProductCategory>()
                {
                    new ProductCategory() {CategoryId = 1, CategoryName = "Test Option 1"},
                    new ProductCategory() {CategoryId = 2, CategoryName = "Test Option 2"},
                    new ProductCategory() {CategoryId = 3, CategoryName = "Test Option 3"},
                    new ProductCategory() {CategoryId = 4, CategoryName = "Test Option 4"}
                },
                SelectedCategoryId = model.SelectedCategoryId
            };
            p.Category = p.Categories.FirstOrDefault(x => x.CategoryId == model.SelectedCategoryId);
            return View(p);
        }
    }
}