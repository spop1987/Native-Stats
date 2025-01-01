namespace Football.Models.ApiFootballResponseDtos
{
    public class Competition
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public required string Type { get; set; }
        public required string Emblem { get; set; }
    }
}