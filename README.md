# Base62.Net

Base62 Convertor for .Net

Convert between byte array and base62 string.

Special thanks to [Mengye Ren](https://github.com/renmengye) and his [base62-csharp](https://github.com/renmengye/base62-csharp), and [Daniel Destouche](https://github.com/ghost1face) and his [base62](https://github.com/ghost1face/base62).

Example
-------------

```csharp
var s = (new byte[] { 116, 32, 8, 99, 100, 232, 4, 7 }).ToBase62();

var b = "T208OsJe107".FromBase62();
```

## License

The MIT License

More info see [LICENSE](LICENSE)