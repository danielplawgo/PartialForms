using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PartialForms.ViewModels.Shared;

namespace PartialForms.ViewModels.Users
{
    public class UserViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AddressViewModel Address { get; set; } = new AddressViewModel();
    }
}