using Newtonsoft.Json;

namespace FirebasePushNotificaiton.Models
{
    /// <summary>
    /// Firebase Message Notification Model
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Set sound default and badge 1
        /// </summary>
        public Notification()
        {
            if (string.IsNullOrWhiteSpace(Sound))
                Sound = "default";
            if (string.IsNullOrWhiteSpace(Badge))
                Badge = "1";
        }

        /// <summary>
        /// Title of notification
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Description of notification
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Sound of notification
        /// </summary>
        [JsonProperty("sound")]
        public string Sound { get; set; }

        /// <summary>
        /// Notification Badge 
        /// </summary>
        [JsonProperty("badge")]
        public string Badge { get; set; }
    }
}
