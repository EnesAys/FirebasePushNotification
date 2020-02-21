using System.Threading.Tasks;

namespace FirebasePushNotificaiton.Interfaces
{
    /// <summary>
    /// Notification Interface
    /// </summary>
    public interface INotification<T> where T : class
    {
        /// <summary>
        /// Notification Send Method
        /// </summary>
        Task<bool> Send(T notificationObject);
    }
}
