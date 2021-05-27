using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> List = new List<Department>();
            List.Add(new Department { Id = 1, Name = "Eletronics" });
            List.Add(new Department { Id = 2, Name = "Suport" });
            List.Add(new Department { Id = 3, Name = "Commercial" });
            return View(List);

        }
    }
}
