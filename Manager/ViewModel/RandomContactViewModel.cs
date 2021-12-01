using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Manager.Models;

namespace Manager.ViewModel
{
    public class RandomContactViewModel
    {
        public Contact Contact { get; set; }
        public List<Client> Clients { get; set; }
    }
}