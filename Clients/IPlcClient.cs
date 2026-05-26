using Dreamine.PLC.Abstractions.Connections;
using Dreamine.PLC.Abstractions.Devices;
using Dreamine.PLC.Abstractions.Results;

namespace Dreamine.PLC.Abstractions.Clients;

/// <summary>
/// Defines a vendor-neutral PLC client.
/// </summary>
public interface IPlcClient : IAsyncDisposable
{
    /// <summary>
    /// Gets the current PLC connection state.
    /// </summary>
    PlcConnectionState State { get; }

    /// <summary>
    /// Occurs when the PLC connection state changes.
    /// </summary>
    event EventHandler<PlcConnectionState>? StateChanged;

    /// <summary>
    /// Connects to the PLC.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The PLC operation result.</returns>
    Task<PlcResult> ConnectAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Disconnects from the PLC.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The PLC operation result.</returns>
    Task<PlcResult> DisconnectAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Reads bit values from the PLC.
    /// </summary>
    /// <param name="address">The start PLC address.</param>
    /// <param name="count">The number of bits to read.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The read bit values.</returns>
    Task<PlcResult<bool[]>> ReadBitsAsync(
        PlcAddress address,
        int count,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Reads word values from the PLC.
    /// </summary>
    /// <param name="address">The start PLC address.</param>
    /// <param name="count">The number of words to read.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The read word values.</returns>
    Task<PlcResult<short[]>> ReadWordsAsync(
        PlcAddress address,
        int count,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Writes bit values to the PLC.
    /// </summary>
    /// <param name="address">The start PLC address.</param>
    /// <param name="values">The bit values to write.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The PLC operation result.</returns>
    Task<PlcResult> WriteBitsAsync(
        PlcAddress address,
        IReadOnlyList<bool> values,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Writes word values to the PLC.
    /// </summary>
    /// <param name="address">The start PLC address.</param>
    /// <param name="values">The word values to write.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The PLC operation result.</returns>
    Task<PlcResult> WriteWordsAsync(
        PlcAddress address,
        IReadOnlyList<short> values,
        CancellationToken cancellationToken = default);
}