using SquadPortfolio.Models;

namespace SquadPortfolio.Services;

public class PortfolioDataService
{
    public IReadOnlyList<ProjectModel> GetProjects() =>
    [
        new ProjectModel(
            Title: "Squad × Blazor Portfolio",
            Description: "Portfolio personnel construit avec une équipe de 5 agents IA orchestrés par Squad. Démontre l'utilisation d'agents IA (Lead, Frontend, Backend, Tester, Scribe) dans un contexte de développement réel, déployé sur VPS Windows avec IIS.",
            Tags: ["Blazor", ".NET 8", "Squad", "AI Agents", "MudBlazor", "IIS", "GitHub Actions"],
            GitHubUrl: "https://github.com/YendouboameHQ/squad-blazor-portfolio",
            LiveUrl: "https://aime-woagou.duckdns.org",
            ImageUrl: null,
            IsFeatured: true
        ),
        new ProjectModel(
            Title: ".NET 9 Starter Kit Blazor",
            Description: "Starter kit .NET 9 production-ready avec architecture Clean/Modulaire, support multitenancy, Web API + Blazor Client. Économise 200+ heures de développement.",
            Tags: ["C#", ".NET 9", "Blazor", "Clean Architecture", "Multitenancy", "Web API"],
            GitHubUrl: "https://github.com/YendouboameHQ/dotnet-starter-kit-blazor",
            LiveUrl: null,
            ImageUrl: null,
            IsFeatured: true
        ),
        new ProjectModel(
            Title: "30 Days SQL Roadmap",
            Description: "Parcours structuré de 30 jours pour maîtriser SQL et T-SQL, avec exercices progressifs couvrant les requêtes de base jusqu'aux concepts avancés (fenêtrage, CTEs, optimisation).",
            Tags: ["SQL", "T-SQL", "Base de données", "Formation"],
            GitHubUrl: "https://github.com/YendouboameHQ/30-days-sql-roadmap",
            LiveUrl: null,
            ImageUrl: null,
            IsFeatured: false
        ),
        new ProjectModel(
            Title: "JavaScript 30 Days Challenge",
            Description: "Challenge 30 jours JavaScript : parcours à travers les concepts fondamentaux via des exercices quotidiens et des mini-projets pratiques.",
            Tags: ["JavaScript", "Formation", "Frontend"],
            GitHubUrl: "https://github.com/YendouboameHQ/javascript-30-days-challenge",
            LiveUrl: null,
            ImageUrl: null,
            IsFeatured: false
        ),
        new ProjectModel(
            Title: "Dev Bookmarks",
            Description: "Collection de ressources développeur classées par thème avec mots-clés pour retrouver rapidement les meilleurs outils, articles et références.",
            Tags: ["JavaScript", "Outillage", "Productivité"],
            GitHubUrl: "https://github.com/YendouboameHQ/dev-bookmarks",
            LiveUrl: null,
            ImageUrl: null,
            IsFeatured: false
        ),
    ];

    public IReadOnlyList<SkillModel> GetSkills() =>
    [
        new SkillModel("C# / .NET", "Backend", 5),
        new SkillModel("Blazor", "Frontend", 4),
        new SkillModel("Web API / REST", "Backend", 5),
        new SkillModel("SQL / T-SQL", "Data", 4),
        new SkillModel("PostgreSQL", "Data", 4),
        new SkillModel("JavaScript", "Frontend", 3),
        new SkillModel("Azure", "Cloud", 3),
        new SkillModel("Docker", "DevOps", 3),
        new SkillModel("GitHub Actions", "DevOps", 4),
        new SkillModel("IIS / Windows Server", "DevOps", 3),
        new SkillModel("AI / Agents IA", "IA", 4),
        new SkillModel("Squad Framework", "IA", 4),
    ];

    public IReadOnlyList<string> GetAllTags() =>
        GetProjects()
            .SelectMany(p => p.Tags)
            .Distinct()
            .OrderBy(t => t)
            .ToList();
}
