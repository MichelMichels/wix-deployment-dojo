:movie_camera: [Youtube](https://www.youtube.com/watch?v=ga9M4m6MtSU)

<hr/>

# Deployment Dojo - Episode 7: Moving beyond upgrades to groups and files

## Grouping of `Component`s

You can group multiple `Component` tags inside a `ComponentGroup`. You can also drop the `Directory` attribute on the individual components and set it on the componentgroup tag.

```xml
<ComponentGroup Id="InstallComponents" Directory="InstallFolder">
    <Component>
        <File Source="ep7a.txt" />
    </Component>
    <Component>
        <File Source="ep7b.txt" />
    </Component>
</ComponentGroup>
```

These groups can then be referenced inside a feature, instead of putting all the components directly inside the `Feature` tag.

```xml
<Feature Id="Main">
    <ComponentGroupRef Id="InstallComponents" />
</Feature>
```

## `Fragment`

With the `Fragment` tag, it's possible to put our wxs code into separate files.

```xml
<Wix xmlns="http://wixtoolset.org/schemas/v4/wxs">
    <Fragment>
        <ComponentGroup Id="InstallComponents" Directory="InstallFolder">
            <Component>
                <File Source="ep7a.txt" />
            </Component>
            <Component>
                <File Source="ep7b.txt" />
            </Component>
        </ComponentGroup>
    </Fragment>
</Wix>
```

You can build this by using following command:

```cmd
wix build .\ep7.wxs .\files.wxs -o v1b\ep7.msi
```