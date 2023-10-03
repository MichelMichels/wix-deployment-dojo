CALL C:\Install\dotnet\vars.cmd
CALL C:\Install\dotnet\dotnet-runtime.cmd

start C:\dojo\Ep15\Ep15\bin\x64\Debug\en-US
start appwiz.cpl
start regedit

msiexec /i C:\dojo\Ep15-v1.msi /qb