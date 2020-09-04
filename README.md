# unity-shared-library

Using shared library inside Unity game

# Req

* Dotnet 3+
* Unity 2019+


Ubuntu

```bash
sudo apt update && \
sudo apt install -y apt-transport-https dotnet-sdk-3.1
```

# Steps

1. Library

```bash
cd calc-lib
dotnet build
```

2. Client (Console)

```bash
cd calc-cli
dotnet build
```

3. Client (Unity)

```bash
cp calc-lib/bin/Debug/netcoreapp3.1/calc-lib.dll calc-cli-unity/Assets/Plugins
```

![](unity-play.png)


# Ref

* [referencing-a-net-dll-directly-using-the-net-core-toolchain](https://medium.com/@tonerdo/referencing-a-net-dll-directly-using-the-net-core-toolchain-16f0af46a4dc)
* [loading-native-libraries-in-c#](https://dev.to/jeikabu/loading-native-libraries-in-c-fh6)
* [how-to-reload-native-plugins-in-unity](https://www.forrestthewoods.com/blog/how-to-reload-native-plugins-in-unity/)
* [dotnet on linux](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu)