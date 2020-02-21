# FirebasePushNotification
Send Firebase Push Notification via nuget package

Install nuget package 

Package Manager Console

```
Install-Package FirebasePushNotification.EnesAys -Version 1.0.0
```

Nuget Package Manager
search "FirebasePushNotification.EnesAys"

```
INotification <FirebaseMessage> _firebasePushNotificationService = new FirebasePushNotificationService("Your Firebase Console Server Key");
```

This line for example, you should use injection.

Use Send Method for push notification.

```
_firebasePushNotificationService.Send(new FirebaseMessage
            {
                To = "Spesific User Token", 
                /* You can use Registration_Ids for list of device tokens
                Registration_Ids = new String[] { "token1", "token2", "token3" },*/
                Notification = new Notification
                {
                    Title = "Test",
                    Text = "Test Description"
                },
                Data = new
                {
                    url = "http://enesaysan.com/"
                }
            })
```