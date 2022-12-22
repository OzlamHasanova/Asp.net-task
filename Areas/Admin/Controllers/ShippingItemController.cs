using DataAccess1.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace WebAppUI.Areas.Admin.Controllers;
[Area("Admin")]
public class ShippingItemController : Controller
{
    private AppDbContext _context;

    public ShippingItemController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Detail(int id)
    {
        var model=await _context.SlideItems.FindAsync(id)  ;
        return View(model);
    }
    public IActionResult Index()
    {
        return View(_context.ShippingItems);
    }
        
    
    public IActionResult Updated(int id)
    {
        return Content(id.ToString());
    }
    public IActionResult Delete(int id)
    {
        return Content(id.ToString());
    }
}
