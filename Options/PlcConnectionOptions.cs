namespace Dreamine.PLC.Abstractions.Options;

/// <summary>
/// Represents common PLC connection options.
/// </summary>
public sealed class PlcConnectionOptions
{
    /// <summary>
    /// Gets or sets the PLC host address.
    /// </summary>
    public string Host { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the PLC port.
    /// </summary>
    public int Port { get; set; }

    /// <summary>
    /// Gets or sets the connection timeout in milliseconds.
    /// </summary>
    public int ConnectTimeoutMs { get; set; } = 3000;

    /// <summary>
    /// Gets or sets the read timeout in milliseconds.
    /// </summary>
    public int ReadTimeoutMs { get; set; } = 3000;

    /// <summary>
    /// Gets or sets the write timeout in milliseconds.
    /// </summary>
    public int WriteTimeoutMs { get; set; } = 3000;

    /// <summary>
    /// Gets or sets the logical station number.
    /// </summary>
    public int StationNumber { get; set; }
}