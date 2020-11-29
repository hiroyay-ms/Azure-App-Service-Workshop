using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNET_SAMPLE.Models;

namespace ASPNET_SAMPLE.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewData["message"] = "Hello from HelloWorld Controller";

            return View();
        }

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        //public string Welcome(string name, int id = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {id}");
        //}

        //public string Welcome(int key)
        //{
        //    var students = new Dictionary<int, Student>()
        //    {
        //        { 1, new Student(){ Name = "Alice", Id = 111 } },
        //        { 2, new Student(){ Name = "Bob", Id = 112 } },
        //        { 3, new Student(){ Name = "Frank", Id = 113 } },
        //        { 4, new Student(){ Name = "Ivan", Id = 114 } },
        //        { 5, new Student(){ Name = "Judy", Id = 115 } }
        //    };

        //    return $"Hello {students[key].Name}, ID is: {students[key].Id}";
        //}

        public Student Welcome(int key)
        {
            var students = new Dictionary<int, Student>()
            {
                { 1, new Student { Name = "Alice", Id = 111 } },
                { 2, new Student { Name = "Bob", Id = 112 } },
                { 3, new Student { Name = "Frank", Id = 113 } },
                { 4, new Student { Name = "Ivan", Id = 114 } },
                { 5, new Student { Name = "Judy", Id = 115 } }
            };

            return students[key];
        }

        [HttpPost]
        public IActionResult Result(int key)
        {
            Student model;

            try
            {
                model = Welcome(key);
            }
            catch
            {
                return View("Error", new ErrorViewModel { RequestId = "1" });
            }

            return View(model);
        }
    }
}
