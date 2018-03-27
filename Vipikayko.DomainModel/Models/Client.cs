using System;
using System.Collections.Generic;
using System.Text;

namespace Vipikayko.DomainModel.Models
{
    public class Client
    {
        public string ContactName { get; set; }

        public string ContactPhone { get; set; }

        public long AddressId { get; set; }

        public Address Address { get; set; }
    }
}
