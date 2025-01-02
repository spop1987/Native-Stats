using System.Text.Json;
using Football.Models.ApiFootballResponseDtos;
using Football.Services.Interfaces;

namespace Football.Services
{
    public class FootballService : IFootballService
    {
        private readonly HttpClient _httpClient;
        private readonly List<string> _leagues;
        public FootballService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _leagues = ["PPL", "PL", "DED", "BL1", "SA", "PD", "BSA",];
        }
        public async Task<Dictionary<string, List<Match>>> GetMatches()
        {
            var matches = new Dictionary<string, List<Match>>();
            var dateFrom = DateTime.UtcNow.AddMonths(-1).ToString("yyyy-MM-dd");
            var dateTo = DateTime.UtcNow.AddMonths(1).ToString("yyyy-MM-dd");
            foreach (var league in _leagues)
            {
                try
                {
                    var response = await _httpClient.GetAsync($"competitions/{league}/matches?dateFrom={dateFrom}&dateTo={dateTo}");
                    response.EnsureSuccessStatusCode();

                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
                    
                    var leagueMatches = JsonSerializer.Deserialize<LeagueMatchesResponse>(content, options);
                    if(leagueMatches != null)
                        matches[league] = leagueMatches.Matches;
                    else
                        matches[league] = []; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return matches;
        }
    }
}