namespace Football.Models.ApiFootballResponseDtos
{
    public class Filters
    {
        public required string Season { get; set; }
        public List<string>? Status { get; set; }
    }
}