using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;
using static HouseRentingSystem.Core.Constants.MessageConstants;

namespace HouseRentingSystem.Core.Models.House
{
	public class HouseFormModel
	{
		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(HouseTitleMaxLenght, MinimumLength = HouseTitleMinLenght, ErrorMessage = LengthMessage)]
		public string Title { get; set; } = null!;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(HouseAddressMaxLenght, MinimumLength = HouseAddressMinLenght, ErrorMessage = LengthMessage)]
		public string Address { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
		[StringLength(HouseDescriptionMaxLenght, MinimumLength = HouseDescriptionMinLenght, ErrorMessage = LengthMessage)]
		public string Description { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
		[Display(Name = "Image URL")]
		public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
		[Range(typeof(decimal), HousePricePerMonthMinRange, 
			HousePricePerMonthMaxRange, 
			ConvertValueInInvariantCulture = true,
			ErrorMessage = "Price Per Month must be a positive number and less than {2} leva.")]
		[Display(Name = "Price Per Month")]
		public decimal PricePerMonth { get; set; }

		[Display(Name = "Category")]
		public int CategoryId { get; set; }

		public IEnumerable<HouseCategoryServiceModel> Categories { get; set; }= new List<HouseCategoryServiceModel>();
	}
}
