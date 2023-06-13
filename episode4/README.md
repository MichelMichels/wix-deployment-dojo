:movie_camera: [Youtube](https://www.youtube.com/watch?v=IXc6_i0Pm4E)

<hr/>

# Deployment Dojo - Episode 4: Out with the Old. In with the New.

## Upgrading

The `UpgradeCode` attribute inside `Package` identifies a software package and all their versions.

The `MajorUpgrade` tag inside the `Package` indicates that previous versions should be removed before installing the current installer. The previous versions get discovered through the `UpgradeCode` attribute.

:warning: This is a **very** important step to include. When you don't add this in your first script, you can downgrade even when you don't want this if you later add this to your setup script.

## Commands

**Command to output build in subdirectory:**

```cmd
wix build ep4.wxs -o v0.9.1
```