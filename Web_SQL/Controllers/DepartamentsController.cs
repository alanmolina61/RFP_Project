using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_SQL.Models;

namespace Web_SQL.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> List = new List<Departament>();
            List.Add(new Departament { Id = 1, Name = "Electronics" });
            List.Add(new Departament { Id = 2, Name = "Fashion" });
            return View(List);
        }
    }
}