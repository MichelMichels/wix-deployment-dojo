:movie_camera: [Youtube](https://www.youtube.com/watch?v=sLk0IRXUiA4)

<hr/>

# Deployment Dojo - Episode 15: What's a WXL?

When adding a HeatWave MSI package project, it will create the default file `Package.en-us.wxl`.

```xml
<!--
This file contains the declaration of all the localizable strings.
-->
<WixLocalization xmlns="http://wixtoolset.org/schemas/v4/wxl" Culture="en-US">

  <String Id="DowngradeError" Value="A newer version of [ProductName] is already installed." />

</WixLocalization>
```

This is a localization file.
These localized variables are used with `!(loc.id)`.

```xml
<MajorUpgrade DowngradeErrorMessage="!(loc.DowngradeError)" />
```