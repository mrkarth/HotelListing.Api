namespace HotelListing.Api.DTOs.Country
{
    public class CreateCountryDto
    {
        public int CountryId { get; set; }
        public required string Name { get; set; }
        public required string ShortName { get; set; }
    }
}
