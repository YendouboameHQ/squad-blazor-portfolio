using System.Net.Http.Json;

namespace SquadPortfolio.Services;

public record GitHubRepo(
    string Name,
    string? Description,
    string Html_url,
    string? Language,
    int Stargazers_count,
    int Forks_count,
    bool Fork,
    string? Homepage
);

public class GitHubService(HttpClient http)
{
    private const string Username = "YendouboameHQ";
    private List<GitHubRepo>? _cache;

    public async Task<IReadOnlyList<GitHubRepo>> GetReposAsync()
    {
        if (_cache is not null) return _cache;

        try
        {
            var repos = await http.GetFromJsonAsync<List<GitHubRepo>>(
                $"https://api.github.com/users/{Username}/repos?sort=updated&per_page=20",
                new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            _cache = repos?.Where(r => !r.Fork).OrderByDescending(r => r.Stargazers_count).ToList() ?? [];
        }
        catch
        {
            _cache = [];
        }

        return _cache;
    }
}
