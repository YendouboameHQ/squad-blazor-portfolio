using System.Net;
using System.Net.Http.Json;
using SquadPortfolio.Services;
using Xunit;

namespace SquadPortfolio.Tests;

public class GitHubServiceTests
{
    [Fact]
    public async Task GetReposAsync_ReturnsEmptyListOnHttpError()
    {
        var handler = new FakeHttpMessageHandler(HttpStatusCode.InternalServerError, "");
        var http = new HttpClient(handler) { BaseAddress = new Uri("https://api.github.com") };
        var sut = new GitHubService(http);

        var repos = await sut.GetReposAsync();

        Assert.Empty(repos);
    }

    [Fact]
    public async Task GetReposAsync_FiltersOutForks()
    {
        var json = """
            [
                {"name":"original","description":"","html_url":"https://github.com/test/original","language":"C#","stargazers_count":5,"forks_count":0,"fork":false,"homepage":null},
                {"name":"forked","description":"","html_url":"https://github.com/test/forked","language":"C#","stargazers_count":0,"forks_count":0,"fork":true,"homepage":null}
            ]
            """;
        var handler = new FakeHttpMessageHandler(HttpStatusCode.OK, json);
        var http = new HttpClient(handler) { BaseAddress = new Uri("https://api.github.com") };
        var sut = new GitHubService(http);

        var repos = await sut.GetReposAsync();

        Assert.Single(repos);
        Assert.Equal("original", repos[0].Name);
    }

    [Fact]
    public async Task GetReposAsync_CachesResults()
    {
        var json = """[{"name":"repo1","description":"","html_url":"https://github.com/test/repo1","language":"C#","stargazers_count":0,"forks_count":0,"fork":false,"homepage":null}]""";
        var handler = new FakeHttpMessageHandler(HttpStatusCode.OK, json);
        var http = new HttpClient(handler) { BaseAddress = new Uri("https://api.github.com") };
        var sut = new GitHubService(http);

        await sut.GetReposAsync();
        await sut.GetReposAsync();

        Assert.Equal(1, handler.CallCount);
    }
}

internal class FakeHttpMessageHandler(HttpStatusCode status, string content) : HttpMessageHandler
{
    public int CallCount { get; private set; }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        CallCount++;
        return Task.FromResult(new HttpResponseMessage(status)
        {
            Content = new StringContent(content, System.Text.Encoding.UTF8, "application/json")
        });
    }
}
