namespace Spotify.CustomException
{
    /// <summary>
    /// Exception that is thrown when a radio station is not found.
    /// </summary>
    public class RadioNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioNotFoundException"/> class.
        /// </summary>
        public RadioNotFoundException() : base() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioNotFoundException"/> class
        /// with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public RadioNotFoundException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioNotFoundException"/> class
        /// with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public RadioNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
