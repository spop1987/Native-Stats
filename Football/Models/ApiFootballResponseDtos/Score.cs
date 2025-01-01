namespace Football.Models.ApiFootballResponseDtos
{
    public class Score
    {
        public required string Winner { get; set; }
        public required string Duration { get; set; }
        public required Time FullTime { get; set; }
        public required Time HalfTime { get; set; }
    }
}