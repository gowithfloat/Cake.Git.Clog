## Cake.Git.Clog [![Test](https://github.com/gowithfloat/Cake.Git.Clog/actions/workflows/test.yml/badge.svg)](https://github.com/gowithfloat/Cake.Git.Clog/actions/workflows/test.yml) [![NuGet](https://img.shields.io/nuget/v/Cake.Git.Clog)](https://www.nuget.org/packages/Cake.Git.Clog/)

Helps prepare a changelog for the changes between two commits. This is a wrapper around the [git-clog](https://github.com/mediabounds/git-clog) command.

## Building

This project can be built using [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/) or [Cake](https://cakebuild.net/). It is recommended that you build this project by invoking the bootstrap script:

    ./build.sh

There are a number of optional arguments that can be provided to the bootstrapper that will be parsed and passed on to Cake itself. See the [Cake build file](./build.cake) in order to identify all supported parameters.

    ./build.sh \
        --task=Build \
        --projectName=Cake.Git.Clog \
        --configuration=Debug \
        --nugetUrl=https://nuget.org \
        --nugetToken=####

## License

All content in this repository is shared under an MIT license. See [license.md](./license.md) for details.
