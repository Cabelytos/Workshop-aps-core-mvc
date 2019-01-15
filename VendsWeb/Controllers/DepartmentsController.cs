﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendsWeb.Models;

namespace VendsWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });
            list.Add(new Department { Id = 3, Name = "Motocross" });


            return View(list);
        }
    }
}