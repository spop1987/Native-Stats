namespace Football.Models.ApiFootballResponseDtos
{
    public class LeagueMatchesResponse
    {
        public required Filters Filters { get; set; }
        public required ResultSet ResultSet { get; set; }
        public required Competition Competition { get; set; }
        public required List<Match> Matches { get; set; }
    }
}