using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
      // GET: Home
      //[HandleError]====>put it in Global.asax
     // [Authorize]===>No One will enter the action without  login
      //[AllowAnonymous]===>alow to enter what ever login or not

        public ActionResult Index()
        {
            int x = int.Parse("55hh");
            return View();
        }
    }
}