using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ContactController : Controller
{
    static private Dictionary<int, ContactModel> _contacts= new Dictionary<int, ContactModel>();
    
    // Lista kontaktów
    public IActionResult Index()
    {
        return View();
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
            
        }

        return View("Index");
    }
}