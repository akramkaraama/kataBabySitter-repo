using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KataBabySitterApp.Models;
using KataBabySitter.Api;
using KataBabySitter.Api.Model;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KataBabySitterApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
    

            //List<SelectListItem> workHoursList = new List<SelectListItem>();

            //foreach(int cal in calObj)
            //{
            //    workHoursList.Add(new SelectListItem { Text = cal.ToString(), Value = cal.ToString() });
            //}

       

            return View();
        }




        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
