using System.Net.Http.Json;
using ApplicationLayer;
using AutoMapper;
using DomainLayer;
using Microsoft.EntityFrameworkCore.Metadata;


public class TopFilmsViewerQueriesRepository : ITopFilmsViewerQueries
{
    private readonly HttpClient _httpClient;

    public TopFilmsViewerQueriesRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
