using Newtonsoft.Json;

namespace FirebasePushNotificaiton.Models
{
    /// <summary>
    /// Firebase Api Push Notification Send Method request Model
    /// </summary>

    public class FirebaseMessage
    {
        /// <summary>
        /// List of all devices assigned to a user
        /// </summary>
        [JsonProperty("registration_ids")]
        public string[] Registration_Ids { get; set; }

        /// <summary>
        /// Spesified user device token
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// Notification Model
        /// </summary>
        [JsonProperty("notification")]
        public Notification Notification { get; set; }

        /// <summary>
        /// Object with all extra information you want to send hidden in the notification
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
