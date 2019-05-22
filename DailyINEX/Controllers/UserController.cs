using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary.BusinessLogic;
using DataLibrary.BusinessModel;

namespace DailyINEX.Controllers
{
    public class UserController : Controller
    {
        //Registraion  

        public ActionResult Registration()
        {
            ViewBag.CountryList = CountryProcessor.LoadCountry();
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Company data )
        {
            bool isSaved = CompanyProcessor.SaveCompany(data);
            if (isSaved)
            {
                ViewBag.Message = "Registraion Successfull";

            }
            
            return View();
        }

        //Login
    }
}