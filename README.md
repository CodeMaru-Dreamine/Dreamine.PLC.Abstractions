# Dreamine.PLC.Abstractions

This package defines the vendor-neutral contracts used by the Dreamine PLC package family.

## Purpose

`Dreamine.PLC.Abstractions` is part of the Dreamine PLC package family.

The package is designed to keep PLC communication code separated by responsibility:

- Abstractions define contracts.
- Core provides shared runtime infrastructure.
- Vendor adapters implement device-specific communication.
- WPF provides monitoring and diagnostic UI components.

## Features

- PLC connection abstraction boundary
- PLC device address and memory area contracts
- Read/write request and response contracts
- Transport-independent PLC communication interfaces
- Common result and error models


## Project References

This package has no Dreamine PLC project dependency.

## Target Framework

```xml
<TargetFramework>net8.0</TargetFramework>
```

## Package Metadata

| Item | Value |
|---|---|
| PackageId | `Dreamine.PLC.Abstractions` |
| Version | `1.0.0` |
| License | `MIT` |
| Repository | `https://github.com/CodeMaru-Dreamine/Dreamine.PLC.Abstractions` |
| Project URL | `https://github.com/CodeMaru-Dreamine/Dreamine.PLC.FullKit` |

## Architecture Rule

This repository must not reference application-level projects.

Dependency direction must remain one-way:

```text
Abstractions
    ▲
    │
Core
    ▲
    │
Vendor Adapter / WPF UI Component
```

## License

This project is licensed under the MIT License.
