:movie_camera: [Youtube](https://www.youtube.com/watch?v=g1PBKhq2oe8)

<hr/>

# Deployment Dojo - Episode 12: All the Ways to Change. Variables and Variables. Directories and Properties.

## Registry keys

```xml
<RegistryValue Root="HKLM" Key="Software\~Ep12" Name="Example" Value="Episode 12" />
```

## Preprocessor variables

_Open properties on the Wix project and look for the 'Build' tab._

Change source code before the build. Earliest possible.

For example, when putting in the following:
```
Version=0.9.0
```

This will convert to following xml inside your `wixproj`: 
```xml
<PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|x86'">
    <DefineConstants>Version=0.9.0</DefineConstants>
</PropertyGroup>
```
You can remove the `Condition` argument in the generated code.

To use these variables, you use MSBuild style variable references:

```xml
... Version="$(Version)"...
```

To negate this hardcoded value, you use the `msbuild` command line.
First change following line:
```xml
<DefineConstants>Version=$(OutsideVersion)</DefineConstants>
```
Then use following `msbuild` command:

```cmd
msbuild -Restore -p:OutsideVersion=0.9.1
```

Something weird happens now, that it will compile for ARM64. To negate this, add following parameter to your `msbuild` command line:
```cmd
-p:Platform=x86
```

You can then use `$(Version)` everywhere in your `.wxs` files.

:speech_balloon: To write a literal dollar sign (\$), you can escape it by type double dollar signs (\$\$).


### Command line

You can also use the command line:

```cmd
wix build *.wxs *.wxl -d Version=12.0.8 -o out\ep12.msi
```