namespace Football.Models.ApiFootballResponseDtos
{
    public class ResultSet
    {
        public int Count { get; set; }
        public string? First { get; set; }
        public string? Last { get; set; }
        public int Played { get; set; }
    }
}