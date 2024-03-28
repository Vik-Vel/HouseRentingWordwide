using HouseRentitngSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentitngSystem.Infrastructure.Data.SeedDb
{
	internal class HouseConfiguration : IEntityTypeConfiguration<House>
	{
		public void Configure(EntityTypeBuilder<House> builder)
		{
			builder
				.HasOne(h => h.Category)
				.WithMany(c => c.Houses)
				.HasForeignKey(c => c.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.HasOne(a => a.Agent)
				.WithMany()
				.HasForeignKey(h => h.AgentId)
				.OnDelete(DeleteBehavior.Restrict);

			var data = new SeedData();

			builder.HasData(new House[] {data.ThirdHouse,data.SecondHouse, data.FirstHouse});

		}
	}
}
