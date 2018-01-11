using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ticketshop.Data;
using Ticketshop.Models;

namespace Ticketshop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StatisticsController : Controller
    {
        private readonly ApplicationDbContext _context;


        public StatisticsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var Amount_Events = _context.Events.Count();
            var Amount_Users = _context.Users.Count();
            //double total_money_exclusive = _context.OrdHistory.Sum(x => (x.priced_payed * x.qty_bought));
            //int total_money_exc = (int)total_money_exclusive;
            //double total_money_inclusive = ((total_money_exc / 100 * 21) + total_money_exc);




            ViewBag.Amount_Events = Amount_Events;
            ViewBag.Amount_Users = Amount_Users;
            //ViewBag.total_money_exclusive = total_money_exclusive;
            //ViewBag.total_money_inclusive = total_money_inclusive;
            return View();
        }
    }
}