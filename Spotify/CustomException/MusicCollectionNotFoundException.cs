namespace Spotify.CustomException
{
    /// <summary>
    /// Exception that is thrown when a music collection is not found.
    /// </summary>
    public class MusicCollectionNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCollectionNotFoundException"/> class.
        /// </summary>
        public MusicCollectionNotFoundException() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCollectionNotFoundException"/> class
        /// with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public MusicCollectionNotFoundException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCollectionNotFoundException"/> class
        /// with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public MusicCollectionNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
