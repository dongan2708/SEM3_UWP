using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Models
{
    class ContactUser
    {
        public string ContactName { get; set; }

        public string ContactAge { get; set; }

        public string ContactAddress { get; set; }

        public ContactUser(string contactName, string contactAge, string contactAddress)
        {
            ContactName = contactName;
            ContactAge = contactAge;
            ContactAddress = contactAddress;
        }
    }
}
