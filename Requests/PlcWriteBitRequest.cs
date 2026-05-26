using Dreamine.PLC.Abstractions.Devices;

namespace Dreamine.PLC.Abstractions.Requests;

/// <summary>
/// Represents a PLC bit write request.
/// </summary>
public sealed class PlcWriteBitRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlcWriteBitRequest"/> class.
    /// </summary>
    /// <param name="address">The start PLC address.</param>
    /// <param name="values">The bit values to write.</param>
    public PlcWriteBitRequest(PlcAddress address, IReadOnlyList<bool> values)
    {
        Address = address;
        Values = values ?? throw new ArgumentNullException(nameof(values));
    }

    /// <summary>
    /// Gets the start PLC address.
    /// </summary>
    public PlcAddress Address { get; }

    /// <summary>
    /// Gets the bit values to write.
    /// </summary>
    public IReadOnlyList<bool> Values { get; }
}