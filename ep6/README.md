:movie_camera: [Youtube](https://www.youtube.com/watch?v=vqiEVfeDjpw)

<hr/>

# Deployment Dojo - Episode 6: The Real Problem with Same Version Upgrades in WiX v4

## Static validation

Analysis of the output of the source code without running it.

```cmd
wix msi validate setup.msi
```
Output for the v1.0.0/ep6.msi file:
```cmd
C:\dojo\ep6\ep6.wxs(3) : warning WIX1076: ICE61: This product should remove only older versions of itself. The Maximum version is not less than the current product. (1.0.0 1.0.0)
```

You can skip this warning by using following command:

```cmd
wix msi validate -sice ICE61 v1.0.0/ep6.msi
```

## .wixpdb 

The `wix msi validate` command uses the .wixpdb file to display the line number where warnings are coming from.