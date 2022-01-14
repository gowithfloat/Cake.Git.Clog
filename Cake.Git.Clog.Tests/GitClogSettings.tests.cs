// <copyright file="GitClogSettings.tests.cs" company="Float">
// Copyright (c) 2020 Float, All rights reserved.
// Shared under an MIT license. See license.md for details.
// </copyright>

using Xunit;

namespace Cake.Git.Clog.Tests
{
    public class GitClogSettingsTests
    {
        [Fact]
        public void GitClogSettings()
        {
            var settings = new GitClogSettings();
            Assert.Throws<GitClogException>(settings.Evaluate);
        }
    }
}
