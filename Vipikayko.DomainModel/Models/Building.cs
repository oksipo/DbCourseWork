using System;
using System.Collections.Generic;
using System.Text;
using Vipikayko.Enums;

namespace Vipikayko.DomainModel.Models
{
    public class Building
    {
        public long Id { get; set; }

        public BuildingTypes Type { get; set; }

        public long AddressId { get; set; }

        public Address Address { get; set; }
    }
}