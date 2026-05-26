namespace Dreamine.PLC.Abstractions.Connections;

/// <summary>
/// Defines the connection state of a PLC client.
/// </summary>
public enum PlcConnectionState
{
    /// <summary>
    /// The client is disconnected.
    /// </summary>
    Disconnected = 0,

    /// <summary>
    /// The client is connecting.
    /// </summary>
    Connecting,

    /// <summary>
    /// The client is connected.
    /// </summary>
    Connected,

    /// <summary>
    /// The client is disconnecting.
    /// </summary>
    Disconnecting,

    /// <summary>
    /// The client is in fault state.
    /// </summary>
    Faulted
}