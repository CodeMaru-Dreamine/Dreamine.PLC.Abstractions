namespace Dreamine.PLC.Abstractions.Devices;

/// <summary>
/// Represents a PLC device address.
/// </summary>
/// <param name="DeviceType">The PLC device memory type.</param>
/// <param name="Offset">The device offset.</param>
/// <param name="BitOffset">Optional bit offset for bit-level access.</param>
public readonly record struct PlcAddress(
    PlcDeviceType DeviceType,
    int Offset,
    int? BitOffset = null)
{
    /// <summary>
    /// Returns whether this address points to a bit-level device.
    /// </summary>
    public bool IsBitAddress => BitOffset.HasValue;

    /// <summary>
    /// Returns the address as a readable string.
    /// </summary>
    /// <returns>The formatted PLC address.</returns>
    public override string ToString()
    {
        return BitOffset.HasValue
            ? $"{DeviceType}{Offset}.{BitOffset.Value}"
            : $"{DeviceType}{Offset}";
    }
}