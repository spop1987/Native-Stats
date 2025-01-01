namespace Football.Models.ApiFootballResponseDtos
{
    public class Area
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public required string Flag { get; set; }
    }
}