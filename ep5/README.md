:movie_camera: [Youtube](https://www.youtube.com/watch?v=s1ZdtkD5lZg)

<hr/>

# Deployment Dojo - Episode 5: The Problem with Same Version Upgrades

## Bug in MS installer

There is a bug inside the MS installer that it does not recognize the 4th version number. In the example below, this would be the 'd' number.

```
a.b.c.d
```

This has a couple of consequences while upgrading your software with such small increments (changes of the 'd' number).

1. `a.b.c.d` is equal to `a.b.c.e`
2. Multiple versions of the same software will show up in Windows Programs

## Same version upgrade

The `AllowSameVersionUpgrades` attribute in the `MajorUpgrade` tag allows you to upgrade the same version. This will also cleanup multiple versions installed.

```xml
<MajorUpgrade DowngradeErrorMessage="A newer version was detected." AllowSameVersionUpgrades="yes" />
```