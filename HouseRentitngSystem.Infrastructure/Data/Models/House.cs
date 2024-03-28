using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;


namespace HouseRentitngSystem.Infrastructure.Data.Models
{
	[Comment("House to rent")]
	public class House
	{
		[Key]
		[Comment("House Identifier")]
		public int Id { get; set; }

		[Required]
		[Comment("Title")]
		[MaxLength(HouseTitleMaxLenght)]
		public string Title { get; set; } = string.Empty;

		[Required]
		[Comment("House address")]
		[MaxLength(HouseAddressMaxLenght)]
		public string Address { get; set; } = string.Empty;

		[Required]
		[Comment("House description")]
		[MaxLength(HouseDescriptionMaxLenght)]
		public string Description { get; set; } = string.Empty;

		[Required]
		[Comment("House image URL")]
		public string ImageUrl { get; set; } = string.Empty;

		[Required]
		[Comment("Price per month for house")]
		[Column(TypeName = "decimal(18,2)")]
		//[Range(typeof(decimal),HousePricePerMonthMinRange,HousePricePerMonthMaxRange,ConvertValueInInvariantCulture = true)]
		public decimal PricePerMonth { get; set; }

		[Required]
		[Comment("House Category Identifier")]
		public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public Category Category { get; set; } = null!;

		[Required]
		[Comment("House Agent Identifier")]
		public int AgentId { get; set; }

		[ForeignKey(nameof(AgentId))]
		public Agent Agent { get; set; } = null!;

		[Comment("Renter Identifier")]
		public string? RenterId { get; set; } 




	}
}
