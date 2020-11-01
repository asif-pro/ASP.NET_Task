using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_Practice.Models;

namespace First_Practice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /* public ActionResult Index()
         {
             return View();
         }
        public string Index()
         {
             return "First Hello From ASP.Net";
         
        public ViewResult Index()
        {
            return View();
        }}*/


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Signup()
        {
             
          return View(); 
          
        }

        /* [HttpPost]
         public ActionResult SignupPost(Person p1)
         {
            *//* Person p1 = new Person()
             {
                 Name = Request["fullname"],
                 UserName = Request["username"],
                 BloodGroup = Request["bloodgroup"],
                 Password = Request["password"],
                 DateOfBirth = Request["dob"],
                 Gender = Request["gender"]
             };*//*

             return View("PersonalInfo", p1);
         }*/

        [HttpPost]
        public ActionResult Signup(Person p1)
        {

            TempData["person"] = p1;
            return RedirectToAction("ShowInfo");
        }

        public ActionResult ShowInfo()
        {
            Person p = TempData["person"] as Person;
            return View("PersonalInfo", p);
        }



        /*public ActionResult Dashboard()
        {
            return View();
        }*/
    }
}