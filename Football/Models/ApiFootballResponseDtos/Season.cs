namespace Football.Models.ApiFootballResponseDtos
{
    public class Season
    {
        public int Id { get; set; }
        public required string StartDate { get; set; }
        public required string EndDate { get; set; }
        public int CurrentMatchday { get; set; }
        public Winner? Winner { get; set; }
    }
}