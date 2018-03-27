namespace Vipikayko.DomainModel.Models
{
    public class Address
    {
        public long Id { get; set; }

        public string StreetName { get; set; }

        public string House { get; set; }

        public string Flat { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }
}
