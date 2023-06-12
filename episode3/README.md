:movie_camera: [Youtube](https://www.youtube.com/watch?v=mn3pA4ABNtQ)

<hr/>

# Deployment Dojo - Episode 3: Building a sandbox in the Deployment Dojo

## Windows Sandbox

To automate the installation of our msi packages, we'll run the installers in [Windows Sandbox](https://learn.microsoft.com/en-us/windows/security/application-security/application-isolation/windows-sandbox/windows-sandbox-overview). See the linked page to enable this on your computer before continueing.

The setup for a Windows Sandbox is done with `wsb` files.

```xml
<Configuration>
    <MappedFolders>
        <MappedFolder>
            <HostFolder>C:\dojo\episode2</HostFolder>
            <SandboxFolder>C:\dojo</SandboxFolder>
        </MappedFolder>
        <MappedFolder>
            <HostFolder>C:\dojo\episode3</HostFolder>
            <SandboxFolder>C:\dojo\tools</SandboxFolder>
        </MappedFolder>
    </MappedFolders>
    <LogonCommand>
        <Command>C:\dojo\tools\dojostart.cmd</Command>
    </LogonCommand>
</Configuration>
```

The `MappedFolder` elements map the host folders to the sandbox. `LogonCommand` starts a command on launch, in this case a .cmd file we prepared before.

```cmd
start C:\dojo
start appwiz.cpl

msiexec /i C:\dojo\ep2.msi /l*v C:\dojo\i.txt
```

This `dojostart.cmd` file resides in `C:\dojo\episode3` on our host machine.