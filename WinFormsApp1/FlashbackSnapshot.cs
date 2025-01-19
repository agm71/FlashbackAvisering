namespace FlashbackAvisering
{
    public class TopicsUsersSnapshot
    {
        public List<(string user, string topic)> UsersAndTopics { get; set; } = [];

        public override int GetHashCode()
        {
            string content = "";
            foreach (var (user, topic) in UsersAndTopics)
            {
                content += user + topic;
            }
            return content.GetHashCode();
        }
    }
}
