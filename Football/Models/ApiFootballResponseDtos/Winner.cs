namespace Football.Models.ApiFootballResponseDtos
{
    public class Winner
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ShortName { get; set; }
        public required string Tla { get; set; }
        public required string Crest { get; set; }
        public required string Address { get; set; }
        public required string Website { get; set; }
        public int Founded { get; set; }
        public required string ClubColors { get; set; }
        public required string Venue { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}