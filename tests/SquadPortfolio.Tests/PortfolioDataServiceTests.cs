using SquadPortfolio.Models;
using SquadPortfolio.Services;
using Xunit;

namespace SquadPortfolio.Tests;

public class PortfolioDataServiceTests
{
    private readonly PortfolioDataService _sut = new();

    [Fact]
    public void GetProjects_ReturnsNonEmptyList()
    {
        var projects = _sut.GetProjects();
        Assert.NotEmpty(projects);
    }

    [Fact]
    public void GetProjects_HasAtLeastOneFeaturedProject()
    {
        var projects = _sut.GetProjects();
        Assert.Contains(projects, p => p.IsFeatured);
    }

    [Fact]
    public void GetProjects_AllProjectsHaveTitleAndTags()
    {
        var projects = _sut.GetProjects();
        foreach (var project in projects)
        {
            Assert.False(string.IsNullOrWhiteSpace(project.Title));
            Assert.NotEmpty(project.Tags);
        }
    }

    [Fact]
    public void GetProjects_PortfolioProjectHasCorrectGitHubUrl()
    {
        var projects = _sut.GetProjects();
        var portfolio = projects.FirstOrDefault(p => p.Title.Contains("Portfolio"));
        Assert.NotNull(portfolio);
        Assert.Equal("https://github.com/YendouboameHQ/squad-blazor-portfolio", portfolio.GitHubUrl);
    }

    [Fact]
    public void GetProjects_PortfolioProjectHasLiveUrl()
    {
        var projects = _sut.GetProjects();
        var portfolio = projects.First(p => p.IsFeatured && p.Title.Contains("Portfolio"));
        Assert.NotNull(portfolio.LiveUrl);
    }

    [Fact]
    public void GetSkills_ReturnsNonEmptyList()
    {
        var skills = _sut.GetSkills();
        Assert.NotEmpty(skills);
    }

    [Fact]
    public void GetSkills_AllSkillsHaveValidLevel()
    {
        var skills = _sut.GetSkills();
        foreach (var skill in skills)
        {
            Assert.InRange(skill.Level, 1, 5);
            Assert.False(string.IsNullOrWhiteSpace(skill.Name));
            Assert.False(string.IsNullOrWhiteSpace(skill.Category));
        }
    }

    [Fact]
    public void GetSkills_HasDotNetSkill()
    {
        var skills = _sut.GetSkills();
        Assert.Contains(skills, s => s.Name.Contains(".NET") || s.Name.Contains("C#"));
    }

    [Fact]
    public void GetSkills_HasAISkill()
    {
        var skills = _sut.GetSkills();
        Assert.Contains(skills, s => s.Category == "IA");
    }

    [Fact]
    public void GetAllTags_ReturnsDistinctSortedTags()
    {
        var tags = _sut.GetAllTags();
        Assert.NotEmpty(tags);
        Assert.Equal(tags.Count, tags.Distinct().Count());
        Assert.Equal(tags, tags.OrderBy(t => t).ToList());
    }

    [Fact]
    public void GetAllTags_ContainsBlazorTag()
    {
        var tags = _sut.GetAllTags();
        Assert.Contains("Blazor", tags);
    }
}
