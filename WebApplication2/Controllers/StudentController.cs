﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [Authorize(Roles ="student")]
        public ActionResult Index()
        {
            return View();
        }
    }
}