# Deployment Dojo - Episode 1

## Requirements

* Visual Studio 2022
* WiX v4
    > Latest NuGet version: `dotnet tool install -g wix`
    > Dev build: `dotnet tool install -g wix --version {VERSION}` (see below how to access the dev builds)

## Content

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
nuget sources add -name wixtoolset --source https://nuget.pkg/github.com/wixtoolset/index.json --username {GITHUB_USERNAME} --password {PERSONAL_ACCESS_TOKEN}
```

> :information_source: Remove a source with `nuget sources remove -name {SOURCE_NAME}`

### MSI Package

The following tree is conceptually the inside structure of an MSI package.

* Package
  * Directory tree *[Structure of the application]*
    * Component
      * File
  
  * Feature tree *[Turning on and off certain features, this is mostly 1 feature]*
    * Component

### Creating our first package

WiX package files are XML files with the `.wxs` extension. Following XML is the minimum required for a building an msi package.

```xml
<Wix xmlns="http://wixtoolset.org/schemas/v4/wxs">
    <Package Manufacturer="Deployment Dojo" Name="Kata #1" UpgradeCode="9a1e69eb-4fa4-40e7-9827-43eb2139f5f5" Version="0.9">
    </Package>
</Wix>
```

Save this code as `package.wxs` and build an .msi package with following command:

```cmd
wix build .\package.wxs -o dojo.msi
```

> :warning: When installing this msi package, nothing gets installed and `msiexec` gives an error because we added nothing to this package.