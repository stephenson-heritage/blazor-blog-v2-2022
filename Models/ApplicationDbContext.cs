
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace blazor_blog_v2_2022.Models;

public class ApplicationDbContext : IdentityDbContext
{

	public DbSet<BlogEntry>? Blog { get; set; }
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		 : base(options)
	{
	}
}
