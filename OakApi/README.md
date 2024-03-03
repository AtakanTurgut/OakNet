### OakApi .Net 8.0

## Used Packages
Packages can be installed from the "[NuGet Gallery](https://www.nuget.org/packages/Microsoft.AspNet.Identity.Core)" with the help of the `Tools > NuGet Package Manager > Package Manager Console`.

- [Microsoft.EntityFrameworkCore 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.SqlServer.Design 1.1.6](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer.Design/1.1.6)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design -Version 1.1.6
```
- [Microsoft.EntityFrameworkCore.SqlServer 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Tools 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.25
```
- [Microsoft.EntityFrameworkCore.Design 6.0.25](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/6.0.25)
```
    PM> NuGet\Install-Package Microsoft.EntityFrameworkCore.Design -Version 6.0.25
```

<br />
- [ ] If you get an error like this in the console:
```
    Only the invariant culture is supported in globalization-invariant mode. 
    See https://aka.ms/GlobalizationInvariantMode for more information. 
    (Parameter 'name') en-us is an invalid culture identifier.
```
- [ ] You have to make changes in `.csproj` file of your project, need to add `InvariantGlobalization` attribute to `false` in `PropertyGroup`. [source](https://stackoverflow.com/questions/76394279/scaffold-dbcontext-culturenotfoundexception-only-the-invariant-culture-is-sup)
```html
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <InvariantGlobalization>false</InvariantGlobalization>  // true --> false
  </PropertyGroup>
```