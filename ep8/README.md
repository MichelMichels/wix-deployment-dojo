:movie_camera: [Youtube](https://www.youtube.com/watch?v=_DCFgd9u8EI)

<hr/>

# Deployment Dojo - Episode 8: A perfect match: WiX and MSBuild

MSBuild is the build system that Microsoft provides. It automates a lot of steps.

## Project file

The project files have a `wixproj` extension and define the SDK version of WixToolset.

```xml
<Project Sdk="WixToolset.Sdk/4.0.2">
</Project>
```

The msi will be built by MSBuild or `dotnet build`.

```cmd
# dotnet build
dotnet build

# MSBuild
msbuild -Restore
```