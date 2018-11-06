using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialForms.ViewModels.Shared
{
    public class AddressViewModel
    {
        public string Street { get; set; }

        public string Number { get; set; }

        public string City { get; set; }

        public string Postal { get; set; }
    }
}