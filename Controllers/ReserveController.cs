using Cinema.Data;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace Cinema.Controllers
{
    public class ReserveController : Controller
    {
        private readonly IEmailSender _emailSender;
        private ApplicationDbContext db = null;
        public ReserveController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
            db = new ApplicationDbContext();
        }
        public IActionResult Rezerv(string cinemaname, string moviename, DateTime date)
        {

            PersianCalendar pc = new PersianCalendar();
            DateTime dtv = new DateTime(date.Year, date.Month, date.Day, pc);
          

            var mn = db.Movies.Where(a => a.Name==moviename).FirstOrDefault();
            var cn = db.Cinemas.Where(a => a.Name == cinemaname).FirstOrDefault();
           

            if (mn == null && cn == null)
                return RedirectToAction("", "");


            var qrezerv = db.Reserves.Where(a => a.CinemaName == cinemaname && a.MovieName == moviename&&a.Rezerv_Vorod == dtv && a.Date == date).FirstOrDefault();
            if (qrezerv == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                qrezerv.CinemaName = cinemaname;
                qrezerv.MovieName = moviename;
                qrezerv.Date = date;
                return RedirectToAction("ShowReserve", "Reserve");

            }

        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
