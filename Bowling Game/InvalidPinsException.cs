using System.Runtime.Serialization;

namespace Bowling_Game
{
    [Serializable]
    public class InvalidPinsException : Exception
    {
        public InvalidPinsException()
        {
        }

        public InvalidPinsException(string? message) : base(message)
        {
        }

        public InvalidPinsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidPinsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}