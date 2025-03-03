using System;
using System.Collections.Generic;

namespace CSharp1
{
    interface INotificationObserver
    {
        void Update(string message);
    }
    class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Email Notification: " + message);
        }
    }
    class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("SMS Notification: " + message);
        }
    }
    class NotificationService
    {
        private List<INotificationObserver> observers = new List<INotificationObserver>();

        public void Subscribe(INotificationObserver observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(INotificationObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}