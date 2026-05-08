namespace SquadPortfolio.Models;

public record ProjectModel(
    string Title,
    string Description,
    string[] Tags,
    string? GitHubUrl,
    string? LiveUrl,
    string? ImageUrl,
    bool IsFeatured = false
);
