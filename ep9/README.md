:movie_camera: [Youtube](https://www.youtube.com/watch?v=s24zby3MN30)

<hr/>

# Deployment Dojo - Episode 9: Let's Install Something Real


Create a simple console app with following command:

```cmd
dotnet new console -o HelloDojo
```

Build it with `msbuild -Restore`.

Execute the exe with `.\HelloDojo.exe`.


## Build project while buidling msi

Inside `wixproj` you can reference projects to build. This has the major advantage that it will build the referenced projects before the setup and add the `bin\Debug` or `bin\Release` paths to the locations to look for files when building the msi.

```xml
<Project Sdk="WixToolset.Sdk/4.0.2">
    <ItemGroup>
        <ProjectReference Include="..\HelloDojo\HelloDojo.csproj" />
    </ItemGroup>
</Project>
```

## Release build

```cmd
msbuild -Restore -p:Configuration=Release
```