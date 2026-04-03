using Hometask.Domain;
using Hometask.Services;

var order = new Order();
var notificationService = new NotificationService();

order.Attach(notificationService);

order.SetStatus("Blocked");
order.SetStatus("Deleted");