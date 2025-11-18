namespace BadNews.Models.Comments;

public record CommentDto
{
	public string User { get; set; }

	public string Value { get; set; }
}