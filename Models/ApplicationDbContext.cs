
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace blazor_blog_v2_2022.Models;

public class ApplicationDbContext : IdentityDbContext
{
	public virtual DbSet<BlogEntry>? Blog { get; set; }
	public virtual DbSet<BlogComment>? Comments { get; set; }
	public virtual DbSet<IdentityUser>? Accounts { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		 : base(options)
	{
	}
}
