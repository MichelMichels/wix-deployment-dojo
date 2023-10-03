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