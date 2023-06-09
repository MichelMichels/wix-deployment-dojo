# Deployment Dojo - Episode 1

## Requirements

* Visual Studio 2022
* WiX v4
    > `dotnet tool install -g wix`

## FAQ

### How do I install a development build from GitHub packages?

GitHub packages needs authentication to fetch packages from their feeds, so we need to create a personal access token (PAT). Follow next steps:

1. Go to profile settings
2. Developer settings
3. Personal access tokens
4. Create a new one with the scope `read:packages`
5. Scroll to bottom and click 'Generate token'
6. Copy the token to use in the next command

With the token, we're ready to add the wixtoolset GitHub package source to nuget with following command:

```cmd
nuget sources add -name wixtoolset \ 
--source https://nuget.pkg/github.com/wixtoolset/index.json \ 
--username {GITHUB_USERNAME} \ 
--password {PERSONAL_ACCESS_TOKEN}
```

> :information_source: Remove a source with `nuget sources remove -name {SOURCE_NAME}`