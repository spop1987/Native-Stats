namespace Football.Models.ApiFootballResponseDtos
{
    public class Match
    {
        public required Area Area { get; set; }
        public required Competition Competition { get; set; }
        public required Season Season { get; set; }
        public int Id { get; set; }
        public DateTime UtcDate { get; set; }
        public required string Status { get; set; }
        public int Matchday { get; set; }
        public required string Stage { get; set; }
        public string? Group { get; set; }
        public DateTime LastUpdated { get; set; }
        public required Team HomeTeam { get; set; }
        public required Team AwayTeam { get; set; }
        public required Score Score { get; set; }
        public required Odds Odds { get; set; }
        public required List<Referee> Referees { get; set; }
    }
}