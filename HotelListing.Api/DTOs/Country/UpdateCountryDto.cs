using HotelListing.Api.DTOs.Country;
using Microsoft.Build.Framework;

public class UpdateCountryDto : CreateCountryDto
{
    [Required]
    public int CountryId { get; set; }
}