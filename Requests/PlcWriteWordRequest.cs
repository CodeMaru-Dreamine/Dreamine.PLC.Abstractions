using Dreamine.PLC.Abstractions.Devices;

namespace Dreamine.PLC.Abstractions.Requests;

/// <summary>
/// Represents a PLC word write request.
/// </summary>
public sealed class PlcWriteWordRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlcWriteWordRequest"/> class.
    /// </summary>
    /// <param name="address">The start PLC address.</param>
    /// <param name="values">The word values to write.</param>
    public PlcWriteWordRequest(PlcAddress address, IReadOnlyList<short> values)
    {
        Address = address;
        Values = values ?? throw new ArgumentNullException(nameof(values));
    }

    /// <summary>
    /// Gets the start PLC address.
    /// </summary>
    public PlcAddress Address { get; }

    /// <summary>
    /// Gets the word values to write.
    /// </summary>
    public IReadOnlyList<short> Values { get; }
}