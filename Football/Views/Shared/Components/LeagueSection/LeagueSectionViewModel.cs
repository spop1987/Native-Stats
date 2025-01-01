using Football.Models.ApiFootballResponseDtos;

namespace Football.Views.Shared.Components.LeagueSection
{
    public class LeagueSectionViewModel
    {
        public string? LeagueName { get; set; }
        public string? LeagueId { get; set; }
        public List<Match> Matches { get; set; } = [];
    }
}
