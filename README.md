# Dreamine.PLC.Abstractions

[![CI](https://github.com/CodeMaru-Dreamine/Dreamine.PLC.Abstractions/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/CodeMaru-Dreamine/Dreamine.PLC.Abstractions/actions/workflows/ci.yml)
[![Quality Gate](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.PLC.Abstractions&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=CodeMaru-Dreamine_Dreamine.PLC.Abstractions)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.PLC.Abstractions&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=CodeMaru-Dreamine_Dreamine.PLC.Abstractions)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.PLC.Abstractions&metric=coverage)](https://sonarcloud.io/summary/new_code?id=CodeMaru-Dreamine_Dreamine.PLC.Abstractions)

[![License](https://img.shields.io/badge/license-MIT-2496ED.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-8-512BD4.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![NuGet](https://img.shields.io/nuget/v/Dreamine.PLC.Abstractions.svg)](https://www.nuget.org/packages/Dreamine.PLC.Abstractions)
[![Downloads](https://img.shields.io/nuget/dt/Dreamine.PLC.Abstractions.svg)](https://www.nuget.org/packages/Dreamine.PLC.Abstractions)

[![Docs](https://img.shields.io/badge/%F0%9F%93%98%20Docs-dreamine.kr-2496ED)](https://dreamine.kr/libraries?lang=en)
[![Guide](https://img.shields.io/badge/%F0%9F%93%98%20Guide-dreamine.kr-2496ED)](https://dreamine.kr/guide?lang=en)
[![Playground](https://img.shields.io/badge/%F0%9F%8E%AE%20Playground-dreamine.kr-7B2CBF)](https://dreamine.kr/playground?lang=en)
[![Book](https://img.shields.io/badge/%F0%9F%93%96%20Book-Practical%20MVVM%20Architecture-black)](https://bookk.co.kr/bookStore/69c0f1b41461ec1ae849a0f6)

[Korean documentation](./README_KO.md)

Common PLC communication contracts for the Dreamine PLC package family.

This package defines vendor-neutral interfaces and models used by PLC clients, simulator clients, WPF diagnostics, and protocol adapters.

## Purpose

`Dreamine.PLC.Abstractions` is the lowest PLC layer. It must not depend on a specific PLC vendor, transport implementation, WPF UI, or simulator runtime.

```text
Application / Sample
        ↓
Dreamine.PLC.Wpf
        ↓
Dreamine.PLC.Abstractions
        ↑
Vendor Adapters / Core / Simulators
```

## Included contracts

- PLC client abstraction
- PLC connection state model
- PLC device address model
- Bit and word read/write request models
- Operation result models
- Common PLC client options

## Design rules

- Keep this package vendor-neutral.
- Do not reference Mitsubishi, Omron, Siemens, LS, MX Component, or CX-Compolet specific types.
- Do not reference WPF.
- Do not include simulator-only behavior in the abstraction layer.
- Use this package as the stable boundary for every PLC adapter.

## Validation status

This package is validated through the current Dreamine PLC sample flow:

- InMemory PLC client
- Dreamine TCP simulator
- Mitsubishi MC TCP simulator
- Mitsubishi MC UDP simulator
- Omron FINS TCP simulator
- Omron FINS UDP simulator
- WPF PLC monitor binding
- 1PC and 2PC simulator-based read/write and handshake tests

Physical PLC integration still requires vendor-specific testing in each protocol package.

## Vendor runtime policy

This package does not include Mitsubishi MX Component, Omron CX-Compolet, SYSMAC Gateway, or any vendor runtime DLL.

Vendor runtime adapters must be implemented in separate packages and must require users to install and license the vendor software separately.

## License

MIT License.
