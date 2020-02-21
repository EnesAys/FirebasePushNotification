# FirebasePushNotification
Send Firebase Push Notification via nuget package

https://www.nuget.org/packages/FirebasePushNotification.EnesAys/

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

Injection Sample;

```
   private readonly ILogger<HomeController> _logger;
   INotification<FirebaseMessage> _firebasePushNotificationService;
   public HomeController(ILogger<HomeController> logger, INotification<FirebaseMessage> firebasePushNotificationService)
   {
       _logger = logger;
       _firebaseService = firebaseService;
   }
```
Startup.cs

```
 var clearServerTexy= "Your Firebase Console Server Key";
 var myPassPhrase = "MyPassKey";
 var encryptedText = EncryptionHelper.Encrypt(clearServerTexy, myPassPhrase);
 
 services.AddSingleton(typeof(INotification<FirebaseMessage>), new FirebasePushNotificationService(encryptedText, myPassPhrase));
```

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
            });
```
