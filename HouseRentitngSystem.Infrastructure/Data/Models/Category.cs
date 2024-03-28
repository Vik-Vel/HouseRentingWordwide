using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentitngSystem.Infrastructure.Data.Models
{
	[Comment("House category")]
	public class Category
	{
		[Key]
		[Comment("Category Identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(CategoryNameMaxLenght)]
		[Comment("Category name")]
		public string Name { get; set; } = string.Empty;

		public List<House> Houses { get; set; } = new List<House>();
	}
}
