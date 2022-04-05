
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace blazor_blog_v2_2022.Models;

public class BlogComment
{
	public uint BlogCommentId { get; set; }

	public string Content { get; set; } = "";

	[Column(TypeName = "datetime")]
	public DateTime TimePosted { get; set; }

	public virtual IdentityUser? User { get; set; }

	public virtual BlogEntry? BlogEntry { get; set; }

}