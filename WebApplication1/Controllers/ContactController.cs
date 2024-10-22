using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ContactController : Controller
{
    static private Dictionary<int, ContactModel> _contacts= new Dictionary<int, ContactModel>();

    private static int currentID = 0;
    // Lista kontaktów
    public IActionResult Index()
    {
        return View(_contacts);
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

        model.Id = ++currentID;
        _contacts.Add(model.Id, model);
        return View("Index", _contacts);
    }
}