namespace WebMtrcs.Models
{
    public class Metric
    {
        public required string MetricType { get; set; }
        public int Value { get; set; }
        public DateTime Timestamp { get; set; }
    }

}
