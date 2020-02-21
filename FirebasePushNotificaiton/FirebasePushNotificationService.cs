using FirebasePushNotificaiton.Helper;
using FirebasePushNotificaiton.Interfaces;
using FirebasePushNotificaiton.Models;
using FirebasePushNotificaiton.Services;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FirebasePushNotificaiton
{
    /// <summary>
    /// Firebase Push Notification Service
    /// </summary>
    public class FirebasePushNotificationService : INotification<FirebaseMessage>
    {        
        private readonly string _encryptedServerKey;
        private readonly string _passPhrase;

        /// <summary>
        /// Initial Firebase Console Server Key
        /// </summary>
        public FirebasePushNotificationService(string encryptedServerKeyServerKey,string passPhrase)
        {
            _encryptedServerKey = encryptedServerKeyServerKey;
            _passPhrase = passPhrase;
        }

        private static Uri FireBasePushNotificationsURL = new Uri("https://fcm.googleapis.com/fcm/send");

        /// <summary>
        /// Firebase Push Notification Send Method
        /// </summary>
        /// <param name="notificationObject">Firebase Api Push Notification Send Method request Model parameter</param>
        /// <returns> bool </returns>        
        public async Task<bool> Send(FirebaseMessage notificationObject)
        {
            bool sent = false;
            if (ValidateService.ValidateRequest(notificationObject))
            {
                string jsonMessage = JsonConvert.SerializeObject(notificationObject);
                var request = new HttpRequestMessage(HttpMethod.Post, FireBasePushNotificationsURL);

                request.Headers.TryAddWithoutValidation("Authorization", "key=" + EncryptionHelper.Decrypt(_encryptedServerKey,_passPhrase));
                request.Content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");

                HttpResponseMessage result;
                using (var client = new HttpClient())
                {
                    result = await client.SendAsync(request);
                    sent = result.IsSuccessStatusCode;
                }
            }

            return sent;
        }
    }
}
