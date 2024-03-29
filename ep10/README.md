:movie_camera: [Youtube](https://www.youtube.com/watch?v=KyFAhr5u-TM)

<hr/>

# Deployment Dojo - Episode 10: The Path from WiX v3 to WiX v4

## Wix v3 building process

1. `candle.exe`: This is the compiler that creates a `wixobj` file from a `wxs` file. This is an intermediary file.
2. `light.exe`: This is the linker that takes the `wixobj` file and turns it into the `msi`

## Conversion from v3 -> v4

You can convert v3 `wxs` files to v4 with following command.
This command will convert files in place.

```cmd
wix convert *.wxs
```

## Building `wixlib`

* `-bindfiles`: ensures that the text files are included in the library.

```cmd
wix build *.wxs -bindfiles -o team1.wixlib
```