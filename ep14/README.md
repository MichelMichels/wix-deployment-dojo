:movie_camera: [Youtube](https://www.youtube.com/watch?v=cLIg7nxx1ko)

<hr/>

# Deployment Dojo - Episode 14: Last Minute Changes. This Time: Properties in WiX v4

## Properties

Properties are defined while installing.
Inside a `Fragment`, you can define a `Property`;

```xml
<Property Id="FOO" Value="123" />
```

This can be referenced with square brackets:
```xml
Value="[FOO]"
```

We can set this with following command:

```cmd
msiexec /i Ep14.msi FOO=abc
```

:speech_balloon: If you don't define a default value for your property 
and don't provide it on the command line, the value will be blank.

:warning: The command line is again case-insensitive. This means that `foo=xyz` will also work.

:warning: The property inside the source must by all-caps otherwise it can't be set on 
the command line.