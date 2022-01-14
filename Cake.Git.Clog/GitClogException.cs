using System;

namespace Cake.Git.Clog
{
    /// <summary>
    /// An exception type for git-clog.
    /// </summary>
    public class GitClogException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitClogException"/> class.
        /// </summary>
        public GitClogException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitClogException"/> class.
        /// </summary>
        /// <param name="message">The associated message.</param>
        public GitClogException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitClogException"/> class.
        /// </summary>
        /// <param name="message">The associated message.</param>
        /// <param name="innerException">The inner exception.</param>
        public GitClogException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
