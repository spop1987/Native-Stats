namespace Football.Models.ApiFootballResponseDtos
{
    public class Referee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required string Nationality { get; set; }
    }
}