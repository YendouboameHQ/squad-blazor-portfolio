using SquadPortfolio.Models;

namespace SquadPortfolio.Services;

public class PortfolioDataService
{
    public IReadOnlyList<ProjectModel> GetProjects() =>
    [
        new ProjectModel(
            Title: "Squad × Blazor Portfolio",
            Description: "Portfolio personnel construit avec une équipe d'agents IA orchestrés par Squad. Démontre l'utilisation de Squad dans un contexte de développement réel.",
            Tags: ["Blazor", ".NET 8", "Squad", "AI Agents", "MudBlazor"],
            GitHubUrl: "https://github.com/YendouboameHQ/squad-blazor-portfolio",
            LiveUrl: null,
            ImageUrl: null,
            IsFeatured: true
        ),
    ];

    public IReadOnlyList<SkillModel> GetSkills() =>
    [
        new SkillModel("C# / .NET", "Backend", 5),
        new SkillModel("Blazor", "Frontend", 4),
        new SkillModel("SQL / PostgreSQL", "Data", 4),
        new SkillModel("Azure", "Cloud", 3),
        new SkillModel("Docker", "DevOps", 3),
        new SkillModel("GitHub Actions", "DevOps", 4),
        new SkillModel("AI / Agents IA", "IA", 4),
    ];

    public IReadOnlyList<string> GetAllTags() =>
        GetProjects()
            .SelectMany(p => p.Tags)
            .Distinct()
            .OrderBy(t => t)
            .ToList();
}
