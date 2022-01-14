using System.Globalization;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Git.Clog
{
    /// <summary>
    /// Settings for the Cake git-clog tool.
    /// </summary>
    public sealed class GitClogSettings : ToolSettings
    {
        /// <summary>
        /// Gets or sets the output format.
        /// </summary>
        /// <value>The output format.</value>
        public Format Output { get; set; } = Format.Changes;

        /// <summary>
        /// Gets or sets a value indicating whether to be verbose.
        /// </summary>
        /// <value><c>true</c> to be verbose, <c>false</c> otherwise.</value>
        public bool Verbose { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to help.
        /// </summary>
        /// <value><c>true</c> for help, <c>false</c> otherwise.</value>
        public bool Help { get; set; }

        /// <summary>
        /// Gets or sets the range of revisions.
        /// </summary>
        /// <value>The range of revisions.</value>
        public string Range { get; set; }

        internal ProcessArgumentBuilder Evaluate()
        {
            var args = new ProcessArgumentBuilder();
            args.Append($"-o {Output}".ToLower(CultureInfo.CurrentCulture));

            if (Verbose)
            {
                args.Append("-v");
            }

            if (Help)
            {
                args.Append("-h");
            }

            // ultimately the range can/should be determined using LibGit2Sharp
            // also the range should be two distinct values that we can check for validity
            if (string.IsNullOrWhiteSpace(Range))
            {
                throw new GitClogException("Range is required for git-clog.");
            }

            args.Append(Range);

            return args;
        }
    }
}
