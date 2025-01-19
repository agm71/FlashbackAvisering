namespace FlashbackAvisering
{
    public class Settings
    {
        public Dictionary<int, string> Forums { get; set; } = [];
        public List<string> UsersShowAlerts { get; set; } = [];
        public List<string> UsersDoNotShowAlerts { get; set; } = [];
        public int Interval { get; set; } = 30;
    }
}
