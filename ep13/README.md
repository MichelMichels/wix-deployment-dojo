:movie_camera: [Youtube](https://www.youtube.com/watch?v=y14Xd6VJJAw)

<hr/>

# Deployment Dojo - Episode 13: Last Minute Changes: Directories.

## Runtime variables

Setting INSTALLFOLDER through command line:

```cmd
msiexec.exe /i ep13.msi INSTALLFOLDER=C:/~ep13
```

:warning: This only works for uppercase Id-values. 
The command line is case-insensitive, but the `.wxs` file does.

