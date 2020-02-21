using FirebasePushNotificaiton.Models;

namespace FirebasePushNotificaiton.Services
{
    /// <summary>
    /// Firebase Push Notification Send Request Model Validate Service
    /// </summary>
    public static class ValidateService
    {
        /// <summary>
        /// Firebase Push Notification Send Request Model Validate Method
        /// </summary>
        public static bool ValidateRequest(FirebaseMessage notificationObject)
        {
            if (notificationObject == null)
                return false;

            if ((notificationObject.Registration_Ids == null || notificationObject.Registration_Ids.Length < 1) && string.IsNullOrWhiteSpace(notificationObject.To))
                return false;

            if (notificationObject.Notification == null || string.IsNullOrWhiteSpace(notificationObject.Notification.Title))
                return false;

            return true;
        }
    }
}
