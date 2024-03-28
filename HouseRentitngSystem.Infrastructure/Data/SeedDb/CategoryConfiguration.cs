using HouseRentitngSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentitngSystem.Infrastructure.Data.SeedDb
{
	internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			var data = new SeedData();

			builder.HasData(new Category[] { data.DuplexCategory, data.SingleCategory, data.CottageCategory });
		}
	}
}
