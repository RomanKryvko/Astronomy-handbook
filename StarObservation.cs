namespace Довідник_астронома
{
    public class StarObservation
    {
        public string StarName { get; set; }
        public DateTime ObservationDate { get; set; }
        public TimeSpan? StarRiseTime { get; set; }
        public TimeSpan? StarSetTime { get; set; }
    }
}
