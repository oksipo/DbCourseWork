using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vipikayko.DomainModel.Mappings;

namespace Vipikayko.DomainModel
{
    public class MappingHelper
    {
        public void Map(ModelBuilder builder)
        {
            foreach (var mapping in getAllMappings())
            {
                mapping.Map(builder);
            }
        }

        private static IEnumerable<IMapping> getAllMappings()
        {
            yield return new AddressMapping();
            yield return new CityMapping();
            yield return new ClientMapping();
            yield return new FoodMapping();
            yield return new IngredientMapping();
            yield return new FoodIngredientMapping();
            yield return new BuildingMapping();
        }
    }
}
