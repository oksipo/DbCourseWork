using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Vipikayko.DomainModel.Mappings
{
    public interface IMapping
    {
        void Map(ModelBuilder builder);
    }
}
