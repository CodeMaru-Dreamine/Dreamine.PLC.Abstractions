using Dreamine.PLC.Abstractions.Results;

namespace Dreamine.PLC.Abstractions.Devices;

/// <summary>
/// Defines a parser that converts PLC address text into a structured PLC address.
/// </summary>
public interface IPlcAddressParser
{
    /// <summary>
    /// Parses PLC address text.
    /// </summary>
    /// <param name="text">The PLC address text.</param>
    /// <returns>The parsed PLC address result.</returns>
    PlcResult<PlcAddress> Parse(string text);

    /// <summary>
    /// Attempts to parse PLC address text.
    /// </summary>
    /// <param name="text">The PLC address text.</param>
    /// <param name="address">The parsed PLC address.</param>
    /// <returns><c>true</c> if the address text was parsed successfully; otherwise, <c>false</c>.</returns>
    bool TryParse(string text, out PlcAddress address);
}