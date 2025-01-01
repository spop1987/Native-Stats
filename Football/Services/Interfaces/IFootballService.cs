using Football.Models.ApiFootballResponseDtos;

namespace Football.Services.Interfaces
{
    public interface IFootballService
    {
        Task<Dictionary<string, List<Match>>> GetMatches();
    }
}