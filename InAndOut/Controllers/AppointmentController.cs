using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);
        }

        public IActionResult Details(int id)
        {
            string todaysDate = DateTime.Now.ToLongDateString();
            return Ok($"You have entered id: {id} \n and the date is: {todaysDate}");
        }
    }
}
