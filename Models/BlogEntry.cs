
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_blog_v2_2022.Models;

public class BlogEntry : IComparable<BlogEntry>
{

	public uint BlogEntryId { get; set; }
	public string Title { get; set; } = "Blog Entry Title";
	public string Content { get; set; } = "";

	[DataType(DataType.DateTime)]
	[Column(TypeName = "DATETIME")]
	public DateTime TimePosted { get; set; } = DateTime.Now;

	public int CompareTo(BlogEntry? other)
	{
		if (other != null)
			return -1 * TimePosted.CompareTo(other.TimePosted);

		return 1;
	}
}