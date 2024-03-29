# Base62.Net

Base62 Convertor for .Net

Convert between byte array and base62 string.

Special thanks to [Mengye Ren](https://github.com/renmengye) and his [base62-csharp](https://github.com/renmengye/base62-csharp), and [Daniel Destouche](https://github.com/ghost1face) and his [base62](https://github.com/ghost1face/base62).

![GitHub Workflow Status](https://img.shields.io/github/workflow/status/JoyMoe/Base62.Net/build)
[![Codecov](https://img.shields.io/codecov/c/github/JoyMoe/Base62.Net.svg)](https://codecov.io/gh/JoyMoe/Base62.Net)
[![license](https://img.shields.io/github/license/JoyMoe/Base62.Net.svg)](https://github.com/JoyMoe/Base62.Net/blob/master/LICENSE)
[![NuGet](https://img.shields.io/nuget/v/Base62-Net.svg)](https://www.nuget.org/packages/Base62-Net)
[![NuGet](https://img.shields.io/nuget/vpre/Base62-Net.svg)](https://www.nuget.org/packages/Base62-Net/absoluteLatest)
![netstandard2.0](https://img.shields.io/badge/.Net-netstandard2.0-brightgreen.svg)

## Example

```csharp
var s = (new byte[] { 116, 32, 8, 99, 100, 232, 4, 7 }).ToBase62();

var b = "T208OsJe107".FromBase62();
```

## License

The MIT License

More info see [LICENSE](LICENSE)
