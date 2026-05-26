namespace Dreamine.PLC.Abstractions.Devices;

/// <summary>
/// Defines common PLC device memory areas.
/// </summary>
public enum PlcDeviceType
{
    /// <summary>
    /// Unknown or unsupported device type.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Mitsubishi or general data register area.
    /// </summary>
    D,

    /// <summary>
    /// Internal relay area.
    /// </summary>
    M,

    /// <summary>
    /// Input relay area.
    /// </summary>
    X,

    /// <summary>
    /// Output relay area.
    /// </summary>
    Y,

    /// <summary>
    /// Link relay area.
    /// </summary>
    B,

    /// <summary>
    /// Link register area.
    /// </summary>
    W,

    /// <summary>
    /// Retentive register area.
    /// </summary>
    R,

    /// <summary>
    /// File register area.
    /// </summary>
    ZR
}