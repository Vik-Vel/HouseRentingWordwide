﻿using HouseRentitngSystem.Infrastructure.Data.Models;
using HouseRentitngSystem.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentitngSystem.Infrastructure.Data
{
	public class HouseRentingDbContext : IdentityDbContext
	{
		public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new UserConfiguration());
			builder.ApplyConfiguration(new AgentConfiguration());
			builder.ApplyConfiguration(new CategoryConfiguration());
			builder.ApplyConfiguration(new HouseConfiguration());

			base.OnModelCreating(builder);
		}

		public DbSet<Agent> Agents { get; set; } = null!;
		public DbSet<House> Houses { get; set; } = null!;
		public DbSet<Category> Categories { get; set; } = null!;
	}
}
