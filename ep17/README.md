:movie_camera: [Youtube](https://www.youtube.com/watch?v=W0B5ZyZVT4A)

<hr/>

# Deployment Dojo - Episode 17: The Latest WiX Build Variables: Bind Variables

## Recap

| Type         | Description                               |
| ------------ | ----------------------------------------- |
| Preprocessor | Change stuff while building               |
| Localization | Change languages, creates different msi's |


## Bind variables

Using properties inside `.wixlib`.

```xml
<Component>
    <RegistryValue Root="HKLM" Key="SOFTWARE\Dojo" Name="Type" Value="[DojoType]" />
</Component>
```

## Wix variable

> :speech_balloon: These variables are set late at build time.

We use Wix variables to generate build time errors when no value is provided.

```xml
<WixVariable Id="DojoType" Value="Community" />
```

Using a WiX variable:

```xml
!(wix.DojoType)
```

Default value for variable:

```xml 
!(wix.DojoType=Unknown)
```