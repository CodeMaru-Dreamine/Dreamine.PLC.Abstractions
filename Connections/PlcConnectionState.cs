namespace Dreamine.PLC.Abstractions.Connections;

/// <summary>
/// \if KO
/// <para>PLC 클라이언트의 연결 상태를 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines the connection state of a PLC client.</para>
/// \endif
/// </summary>
public enum PlcConnectionState
{
    /// <summary>
    /// \if KO
    /// <para>연결이 해제되었습니다.</para>
    /// \endif
    /// \if EN
    /// <para>The client is disconnected.</para>
    /// \endif
    /// </summary>
    Disconnected = 0,

    /// <summary>
    /// \if KO
    /// <para>연결 중입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The client is connecting.</para>
    /// \endif
    /// </summary>
    Connecting,

    /// <summary>
    /// \if KO
    /// <para>연결되었습니다.</para>
    /// \endif
    /// \if EN
    /// <para>The client is connected.</para>
    /// \endif
    /// </summary>
    Connected,

    /// <summary>
    /// \if KO
    /// <para>연결 해제 중입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The client is disconnecting.</para>
    /// \endif
    /// </summary>
    Disconnecting,

    /// <summary>
    /// \if KO
    /// <para>오류 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The client is in a faulted state.</para>
    /// \endif
    /// </summary>
    Faulted
}
