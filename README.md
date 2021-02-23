# Bug descriptions

## Expected behavior

Run the following in the root of the repository to build and run ConsoleApp2,
which is referencing ConsoleApp1 in a normal way.

```bash
dotnet clean ConsoleApp1
dotnet build ConsoleApp2/ConsoleApp2.csproj
dotnet ConsoleApp2/bin/Debug/net5.0/ConsoleApp2.dll
```

The execution of ConsoleApp2 has the expected output on Linux (Ubuntu 20):

```bash
ConsoleApp1.Resources.SubFolder.Icons.icon.png
```

## Unexpected behavior with symlink on Linux

On Linux run the following command in the root of the repository to prepare the build.

```bash
ln -s ConsoleApp1/ ConsoleAppLink
```

Run the following to build and run ConsoleApp3, which is referencing ConsoleApp1 through a symlink.

```bash
dotnet clean ConsoleApp1
dotnet build ConsoleApp3/ConsoleApp3.csproj
dotnet ConsoleApp3/bin/Debug/net5.0/ConsoleApp3.dll
```

The execution of ConsoleApp2 has the unexpected output on Linux (Ubuntu 20):

```bash
ConsoleApp1.icon.png
```

It works as expected on Windows using either symlink or junction points running on of the following
command in the root of the repository.

```bash
mklink /d ConsoleAppLink ConsoleApp1 # symlink
mklink /j ConsoleAppLink ConsoleApp1 # junction point
```