namespace VivaSphere.Api.Models;

public record Testimonial(
    int Id,
    string AuthorName,
    string AuthorRole,
    string CompanyName,
    string Quote,
    string CompanyLogoUrl
);
