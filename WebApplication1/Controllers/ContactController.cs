using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ContactController : Controller
{
    static private Dictionary<int, ContactModel> _contacts= new Dictionary<int, ContactModel>()
    {
        {1, new() {Id = 1, Email = "ascfsd@gmail.com",FirstName = "Olaf", LastName = "Ciuła", BirthDate = new DateTime(1970, 10,10), PhoneNumber = "333 333 333"}},
        {2, new() {Id = 2, Email = "arfsdd@gmail.com",FirstName = "Ola", LastName = "rresgd", BirthDate = new DateTime(1970, 10,10), PhoneNumber = "333 333 333"}}
    };

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

    public ActionResult Delete(int id)
    {
        _contacts.Remove(id);
        return View("Index", _contacts);
    }

    public ActionResult Details(int id)
    {
        return View(_contacts[id]);
    }
}