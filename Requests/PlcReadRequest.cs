using Dreamine.PLC.Abstractions.Devices;

namespace Dreamine.PLC.Abstractions.Requests;

/// <summary>
/// Represents a PLC read request.
/// </summary>
/// <param name="Address">The start PLC address.</param>
/// <param name="Count">The number of values to read.</param>
public readonly record struct PlcReadRequest(
    PlcAddress Address,
    int Count);