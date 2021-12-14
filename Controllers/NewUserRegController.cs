using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBFORMSAssignment.Models;
using System.Net.Http;

namespace WEBFORMSAssignment.Controllers
{
    public class NewUserRegController : Controller
    {
        // GET: NewUserReg
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(NewUserClass nuc)
        {
            if(ModelState.IsValid)
            { 
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44392/api/UserReg");

            var insertdata = hc.PostAsJsonAsync<NewUserClass>("UserReg", nuc);
            insertdata.Wait();

            var saveddata = insertdata.Result;
            if(saveddata.IsSuccessStatusCode)
            {
                    ViewBag.message = "The User"  + nuc.Username +  "is saved successfully ..!";
            }
            }
            return View();
        }
    }
}