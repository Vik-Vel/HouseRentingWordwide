using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;
using static HouseRentingSystem.Core.Constants.MessageConstants;

namespace HouseRentingSystem.Core.Models.House
{
    public class HouseServiceModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseTitleMaxLenght, MinimumLength = HouseTitleMinLenght, ErrorMessage = LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseAddressMaxLenght, MinimumLength = HouseAddressMinLenght, ErrorMessage = LengthMessage)]
        public string Address { get; set; } = string.Empty;

        [Display(Name = "Image URL")]
        [Required(ErrorMessage = RequiredMessage)]
        public string ImageUrl { get; set; } = string.Empty;

        [Display(Name = "Price Per Month")]
        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal), HousePricePerMonthMinRange,
            HousePricePerMonthMaxRange,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "Price Per Month must be a positive number and less than {2} leva.")]
        public decimal PricePerMonth { get; set; } 

        [Display(Name = "Is Rented")]
        public bool IsRented { get; set; }
    }
}
