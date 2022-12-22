using DataAccess1.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppUI.ViewModels;

namespace WebAppUI.Controllers
{
    public class HomeController : Controller
    {
        //depends injection 
        //prosesin adi invergn of control
        public AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homevm = new()
            {
                SlideItems = _context.SlideItems.AsNoTracking(),
                ShippingItems = _context.ShippingItems.AsNoTracking(),
            };
            return View(homevm);//ienumerable tipinden slide item gelir(select edirikse bu ienumerebldi,query yaziriqsa bu iquerybledi)
        }
        //public IActionResult Test()
        //{
        //    return View();
        //}
       
    }
}
