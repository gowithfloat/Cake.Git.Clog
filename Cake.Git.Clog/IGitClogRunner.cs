using System;
using System.Collections.Generic;

namespace Cake.Git.Clog
{
    /// <summary>
    /// An interface for the git-clog runner.
    /// </summary>
    public interface IGitClogRunner
    {
        /// <summary>
        /// Run git-clog with an action to configure settings.
        /// </summary>
        /// <param name="configure">An action to configure settings.</param>
        /// <returns>The standard output.</returns>
        IEnumerable<string> RunWithResult(Action<GitClogSettings> configure = null);

        /// <summary>
        /// Run git-clog with the given settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The standard output.</returns>
        IEnumerable<string> RunWithResult(GitClogSettings settings);
    }
}
