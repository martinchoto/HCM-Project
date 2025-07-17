using HumanCapitalManagement.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace HumanCapitalManagement.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Department> Departments { get; set; } = null!;
		public DbSet<Employee> Employees { get; set; } = null!;
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<ApplicationUser>(entity =>
			{
				entity.Ignore(u => u.EmailConfirmed);
				entity.Ignore(u => u.PhoneNumberConfirmed);
				entity.Ignore(u => u.TwoFactorEnabled);
				entity.Ignore(u => u.LockoutEnabled);
				entity.Ignore(u => u.LockoutEnd);
				entity.Ignore(u => u.AccessFailedCount);
				entity.Ignore(u => u.PhoneNumber);
				entity.Ignore(u => u.PhoneNumberConfirmed);
			});

			SeedDatabase.SeedRoles(modelBuilder);
			SeedDatabase.SeedDepartments(modelBuilder);
			SeedDatabase.SeedUsersAndEmployees(modelBuilder);
		}
	}
}

