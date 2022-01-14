using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Git.Clog
{
    /// <summary>
    /// The runner for git-clog tasks.
    /// </summary>
    public class GitClogRunner : Tool<GitClogSettings>, IGitClogRunner
    {
        const string GitClog = "git-clog";

        /// <summary>
        /// Initializes a new instance of the <see cref="GitClogRunner"/> class.
        /// </summary>
        /// <param name="fileSystem">The current file system.</param>
        /// <param name="environment">The current environment.</param>
        /// <param name="processRunner">The current process runner.</param>
        /// <param name="tools">The current tools.</param>
        public GitClogRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
        }

        /// <inheritdoc />
        public IEnumerable<string> RunWithResult(Action<GitClogSettings> configure = null)
        {
            var settings = new GitClogSettings();
            configure?.Invoke(settings);
            return RunWithResult(settings);
        }

        /// <inheritdoc />
        public IEnumerable<string> RunWithResult(GitClogSettings settings)
        {
            var process = RunProcess(settings, GetSettingsArguments(settings), new ProcessSettings { RedirectStandardError = false, RedirectStandardOutput = true });
            process.WaitForExit();
            ProcessExitCode(process.GetExitCode());
            return process.GetStandardOutput();
        }

        /// <inheritdoc />
        protected override string GetToolName() => GitClog;

        /// <inheritdoc />
        protected override IEnumerable<string> GetToolExecutableNames() => new[] { GitClog };

        static ProcessArgumentBuilder GetSettingsArguments(GitClogSettings settings) => settings?.Evaluate();
    }
}
