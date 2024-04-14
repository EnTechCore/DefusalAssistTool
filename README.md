# DefusalAssistantTool
A tool to assist in playing the game "Defusal" on Roblox. Built with .NET 8 and hopes and dreams.  
This solution is still in early development, and its accuracy in-game has not been tested.

# Build
You have two options for building:
## Using Visual Studio
1. Download Visual Studio at [https://visualstudio.microsoft.com/](https://visualstudio.microsoft.com/) with ".NET desktop development" ticked during install, if you haven't already.
2. Open the project in Visual Studio, select your build options near the top left, and hit F6 to build.
## Using .NET CLI
1. Install the .NET 8 SDK at [https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0), if you haven't already.
2. Open command prompt and navigate to its folder. It typically installs to "C:\Program Files\dotnet".
3. Run the following to build the solution:
   ```sh
   dotnet build <location>
   ```
   Replace `<location>` with the path to the solution.  
   You may want to see `dotnet build --help` for additional options.
