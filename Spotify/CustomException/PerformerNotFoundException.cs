namespace Spotify.CustomException
{
    /// <summary>
    /// Exception that is thrown when a performer is not found.
    /// </summary>
    public class PerformerNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformerNotFoundException"/> class.
        /// </summary>
        public PerformerNotFoundException() : base() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformerNotFoundException"/> class
        /// with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public PerformerNotFoundException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformerNotFoundException"/> class
        /// with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public PerformerNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
