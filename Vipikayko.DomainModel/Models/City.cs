using System.Collections.Generic;

namespace Vipikayko.DomainModel.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
