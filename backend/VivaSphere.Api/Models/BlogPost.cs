namespace VivaSphere.Api.Models;

public record BlogPost(
    int Id,
    string Slug,
    string Title,
    string Excerpt,
    string Body,
    string Category,
    DateTime PublishedAt,
    string CoverImageUrl
);
