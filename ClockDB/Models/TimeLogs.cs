namespace ClockDB.Models
{
    public class TimeLogs
    {
        public int TimeLogsId { get; set; }
        public int UserId { get; set; }
        public DateTime ClockIn { get; set; } = DateTime.UtcNow;
        public DateTime ClockOut { get; set; } = DateTime.UtcNow;
    }
}
