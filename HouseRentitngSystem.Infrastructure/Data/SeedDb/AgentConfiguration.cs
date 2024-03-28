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
	internal class AgentConfiguration : IEntityTypeConfiguration<Agent>
	{
		public void Configure(EntityTypeBuilder<Agent> builder)
		{
			var data = new SeedData();

			builder.HasData(new Agent[] {data.Agent});
		}
	}
}
