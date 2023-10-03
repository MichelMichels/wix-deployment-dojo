:movie_camera: [Youtube](https://www.youtube.com/watch?v=d4DEPW-RO30)

<hr/>

# Deployment Dojo - Episode 18: Variables End to End. Putting it all together in WiX v4

This is an exercise into a reallife scenario to use all variables and we are given following build script:
```cmd
msbuild -nologo -m  -v:m BeltTest\BeltTest.sln -p:BuildVersion=1.0.0
```

## Version

To set the version in buildtime, we use **preprocessor variables**.

```xml
<!-- This is inside package.wxs -->
Version="$(Version)"

<!-- This is inside the wixproj file -->
<PropertyGroup>
    <BuildVersion>0</BuildVersion>
    <DefineConstants>Version=$(BuildVersion)</DefineConstants>
</PropertyGroup>
```

We also provide the `wixproj` file with a default `BuildVersion`. This is for development purposes.

## Localization

We add a Danish location file:

```xml
<!-- This is Package.da-dk.wxl -->

<!--
This file contains the declaration of all the localizable strings.
-->
<WixLocalization xmlns="http://wixtoolset.org/schemas/v4/wxl" Culture="da-DK">

	<String Id="Manufacturer" Value="~Deployment Dojo (da-DK)" />
	<String Id="DowngradeError" Value="da-DK: A newer version of [ProductName] is already installed." />

</WixLocalization>
```

## Bind variables

```xml
!(bind.Property.Manufacturer)
```

## Runtime variables / Properties

In the example below, `[CUSTOMER]` is the property.

```xml
<RegistryValue Root="HKLM" Key="SOFTWARE\BeltTest" Name="Customer" Value="[CUSTOMER]" />
```

These values get set through the command like so:

```cmd
msiexec setup.msi /i CUSTOMER=FireGiant
```