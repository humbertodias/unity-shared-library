calc-lib

```
dotnet new classlib -o calc-lib
```

calc-cli

```sh
dotnet new console -o calc-cli
cd calc-cli
dotnet add reference ../calc-lib/calc-lib.csproj
dotnet add reference ../calc-lib-c/libcalc.so
```