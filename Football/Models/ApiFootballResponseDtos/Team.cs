namespace Football.Models.ApiFootballResponseDtos
{
    public class Team
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ShortName { get; set; }
        public required string Tla { get; set; }
        public required string Crest { get; set; }
    }
}