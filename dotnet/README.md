# .NET Coding Kata

Template for coding katas in .NET languages. The solution contains two projects,
one for C# and one for F#.

## IDEs

Solution should be compatible with Visual Studio (>= 2022) and Jetbrains Rider.
Make sure to have the
[.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) installed.

## Development Container (Visual Studio Code & Docker)

There is also a [development
container](https://code.visualstudio.com/docs/remote/containers-tutorial) (see
`.devcontainer/devcontainer.json`) that has .NET 6 available, in case you can't
or don't want to install the SDK locally on your machine.

To use the container, you'll need:

- [Docker](https://www.docker.com/products/docker-desktop)
- [VS Code](https://code.visualstudio.com)
- [Remote Containers extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)

With all that available, open *this directory* (`dotnet/`) with VS Code. You
will get prompted that you can open the project in a dev container - do that.
On the first start you'll have to wait for the image to download, which can
take a bit.

The container provides two VS Code extensions:

- [OmniSharp](https://github.com/OmniSharp/omnisharp-vscode) for C#
- [Ionide](https://github.com/ionide/ionide-vscode-fsharp) for F#

OmniSharp takes some time to download and initialize stuff on the first run,
so be a bit patient.  
When the dust has settled, you should be able to:

- run some `dotnet` task from VS Code via `<Ctrl><Shift><t>`
  (build, test, run, publish, …)
- run `dotnet` CLI commands yourself in the internal terminal
  (*Terminal > New Terminal*) - the terminal gives you shell
  *within* the container
- run and debug with `<F5>`

## Resources

- [collection of C# links](https://github.com/yogan/notes/blob/master/languages/csharp.md)
