using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manager.Models;
using Manager.ViewModel;

namespace Manager.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts/Random
        public ActionResult Random()
        {
            var contact = new Contact() { Name = "Sarah"};
            var clients = new List<Client>
            {
                new Client { Name = "Client 1"},
                new Client { Name = "Client 2"}
            };

            var viewModel = new RandomContactViewModel
            {
                Contact = contact,
                Clients = clients
            };
            return View(viewModel);
        }

    }
}