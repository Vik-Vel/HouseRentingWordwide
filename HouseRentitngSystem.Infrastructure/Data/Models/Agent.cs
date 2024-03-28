using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentitngSystem.Infrastructure.Data.Models
{
	[Index(nameof(PhoneNumber), IsUnique = true)] //Add constraint in DB for unique phone number
	[Comment("House Agent")]
	public class Agent
	{
		[Key]
		[Comment("Agent Identifier")]
		public int Id { get; set; }

		[Required]
		[Comment("Agent's Phone Number")]
		[MaxLength(AgentPhoneNumberMaxLenght)]
		public string PhoneNumber { get; set; } = string.Empty;

		[Required]
		[Comment("User Identifier")]
		public string UserId { get; set; } = string.Empty;

		[ForeignKey(nameof(UserId))]
		public IdentityUser User { get; set; } = null!;


	}
}
