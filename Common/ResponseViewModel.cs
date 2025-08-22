using EunigosApi.Models;

namespace EunigosApi.Common
{
    public class ResponseViewModel
    {
        public List<Error> Messages { get; set; } = new List<Error>();

        public bool IsSuccess { get; set; } = true;
        // Method to clear the messages list
        public void ClearMessages()
        {
            //  Messages.Clear();
            Messages = new List<Error>();
        }

        // Method to add a message
        public void AddMessage(Error message)
        {
            Messages.Add(message);
        }

        // Method to remove a message
        public bool RemoveMessage(Error message)
        {
            return Messages.Remove(message);
        }
    }
}
