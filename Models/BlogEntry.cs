
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace blazor_blog_v2_2022.Models;

public class BlogEntry : IComparable<BlogEntry>
{
	public uint BlogEntryId { get; set; }


	[Column(TypeName = "varchar(120)")]
	public string? Title { get; set; }

	public string Content { get; set; } = "";

	[Column(TypeName = "datetime")]
	public DateTime TimePosted { get; set; }

	public virtual IdentityUser? User { get; set; }
	public virtual ICollection<BlogComment> BlogComments {get;set;} = new List<BlogComment>();

	public int CompareTo(BlogEntry? other)
	{
		if (other != null)
		{
			if (this.TimePosted > other.TimePosted)
			{
				return -1;
			}
			else if (this.TimePosted < other.TimePosted)
			{
				return 1;
			}
		}
		return 0;
	}
}