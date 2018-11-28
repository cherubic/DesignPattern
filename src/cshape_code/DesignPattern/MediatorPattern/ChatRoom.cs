using System;
namespace DesignPattern.MediatorPattern
{
    public class ChatRoom
    {
        public ChatRoom()
        {
        }

        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine(DateTime.Today.ToString()
                              + " [" + user.GetName() + "] : " + message);
        }
    }
}
