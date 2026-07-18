using Dreamine.PLC.Abstractions.Connections;
using Dreamine.PLC.Abstractions.Devices;
using Dreamine.PLC.Abstractions.Results;

namespace Dreamine.PLC.Abstractions.Clients;

/// <summary>
/// \if KO
/// <para>공급업체에 독립적인 PLC 클라이언트를 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines a vendor-neutral PLC client.</para>
/// \endif
/// </summary>
public interface IPlcClient : IAsyncDisposable
{
    /// <summary>
    /// \if KO
    /// <para>현재 PLC 연결 상태를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the current PLC connection state.</para>
    /// \endif
    /// </summary>
    PlcConnectionState State { get; }

    /// <summary>
    /// \if KO
    /// <para>PLC 연결 상태가 변경될 때 발생합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Occurs when the PLC connection state changes.</para>
    /// \endif
    /// </summary>
    event EventHandler<PlcConnectionState>? StateChanged;

    /// <summary>
    /// \if KO
    /// <para>PLC에 연결합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Connects to the PLC.</para>
    /// \endif
    /// </summary>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>연결 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The connection cancellation token.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>PLC 연결 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The PLC connection result.</para>
    /// \endif
    /// </returns>
    Task<PlcResult> ConnectAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>PLC 연결을 해제합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Disconnects from the PLC.</para>
    /// \endif
    /// </summary>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>연결 해제 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The disconnection cancellation token.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>PLC 연결 해제 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The PLC disconnection result.</para>
    /// \endif
    /// </returns>
    Task<PlcResult> DisconnectAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>PLC에서 비트 값을 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Reads bit values from the PLC.</para>
    /// \endif
    /// </summary>
    /// <param name="address">
    /// \if KO
    /// <para>시작 PLC 주소입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The start PLC address.</para>
    /// \endif
    /// </param>
    /// <param name="count">
    /// \if KO
    /// <para>읽을 비트 수입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The number of bits to read.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>읽기 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The read cancellation token.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>비트 배열을 포함한 PLC 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The PLC result containing the bit array.</para>
    /// \endif
    /// </returns>
    Task<PlcResult<bool[]>> ReadBitsAsync(
        PlcAddress address,
        int count,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>PLC에서 워드 값을 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Reads word values from the PLC.</para>
    /// \endif
    /// </summary>
    /// <param name="address">
    /// \if KO
    /// <para>시작 PLC 주소입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The start PLC address.</para>
    /// \endif
    /// </param>
    /// <param name="count">
    /// \if KO
    /// <para>읽을 워드 수입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The number of words to read.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>읽기 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The read cancellation token.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>워드 배열을 포함한 PLC 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The PLC result containing the word array.</para>
    /// \endif
    /// </returns>
    Task<PlcResult<short[]>> ReadWordsAsync(
        PlcAddress address,
        int count,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>PLC에 비트 값을 씁니다.</para>
    /// \endif
    /// \if EN
    /// <para>Writes bit values to the PLC.</para>
    /// \endif
    /// </summary>
    /// <param name="address">
    /// \if KO
    /// <para>시작 PLC 주소입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The start PLC address.</para>
    /// \endif
    /// </param>
    /// <param name="values">
    /// \if KO
    /// <para>쓸 비트 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The bit values to write.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>쓰기 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The write cancellation token.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>PLC 쓰기 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The PLC write result.</para>
    /// \endif
    /// </returns>
    Task<PlcResult> WriteBitsAsync(
        PlcAddress address,
        IReadOnlyList<bool> values,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>PLC에 워드 값을 씁니다.</para>
    /// \endif
    /// \if EN
    /// <para>Writes word values to the PLC.</para>
    /// \endif
    /// </summary>
    /// <param name="address">
    /// \if KO
    /// <para>시작 PLC 주소입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The start PLC address.</para>
    /// \endif
    /// </param>
    /// <param name="values">
    /// \if KO
    /// <para>쓸 워드 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The word values to write.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>쓰기 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The write cancellation token.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>PLC 쓰기 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The PLC write result.</para>
    /// \endif
    /// </returns>
    Task<PlcResult> WriteWordsAsync(
        PlcAddress address,
        IReadOnlyList<short> values,
        CancellationToken cancellationToken = default);
}
