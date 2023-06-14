:movie_camera: [Youtube](https://www.youtube.com/watch?v=Q5uHgUdqAeY)

<hr/>

# Deployment Dojo - Episode 2

## Installation

Installing the Wix toolset: 

```ps
dotnet tool install -g wix
```

Uninstalling wix toolset:

```ps
dotnet tool uninstall -g wix
```

### Development builds


GitHub packages needs authentication to fetch packages from their feeds, so we need to create a personal access token (PAT). Follow next steps:

1. Go to profile settings
2. Developer settings
3. Personal access tokens
4. Create a new one with the scope `read:packages`
5. Scroll to bottom and click 'Generate token'
6. Copy the token to use in the next command

With the token, we're ready to add the wixtoolset GitHub package source to nuget with following command:

```cmd
nuget sources add -name wixtoolset --source https://nuget.pkg/github.com/wixtoolset/index.json --username {GITHUB_USERNAME} --password {PERSONAL_ACCESS_TOKEN}
```

Verifying that the source is added: 

```ps
dotnet nuget list source
```

:information_source: Remove a source with `nuget sources remove -name {SOURCE_NAME}`

## Package

```
Package
    > Directory Tree
        > Component
            > File
    
    > Feature Tree
        > Component
```

**Directory tree**

The directory tree is the structure where files are put on the computer.

**Feature tree**

Inside the feature tree are the things that users can turn on and off while installing.

**Component**

Components are used to tie the directory tree and feature tree together.