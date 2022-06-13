using CarProjectBack.DAL;
using CarProjectBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProjectBack.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task< IActionResult> Index()
        {
            
            List<Car> Cars = await _context.Cars.ToListAsync();
            return View(Cars);
        }
    }
}
