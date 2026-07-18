namespace Dreamine.PLC.Abstractions.Options;

/// <summary>
/// \if KO
/// <para>공통 PLC 연결 옵션을 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents common PLC connection options.</para>
/// \endif
/// </summary>
public sealed class PlcConnectionOptions
{
    /// <summary>
    /// \if KO
    /// <para>PLC 호스트 주소를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the PLC host address.</para>
    /// \endif
    /// </summary>
    public string Host { get; set; } = string.Empty;

    /// <summary>
    /// \if KO
    /// <para>PLC 포트를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the PLC port.</para>
    /// \endif
    /// </summary>
    public int Port { get; set; }

    /// <summary>
    /// \if KO
    /// <para>밀리초 단위 연결 제한 시간을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the connection timeout in milliseconds.</para>
    /// \endif
    /// </summary>
    public int ConnectTimeoutMs { get; set; } = 3000;

    /// <summary>
    /// \if KO
    /// <para>밀리초 단위 읽기 제한 시간을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the read timeout in milliseconds.</para>
    /// \endif
    /// </summary>
    public int ReadTimeoutMs { get; set; } = 3000;

    /// <summary>
    /// \if KO
    /// <para>밀리초 단위 쓰기 제한 시간을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the write timeout in milliseconds.</para>
    /// \endif
    /// </summary>
    public int WriteTimeoutMs { get; set; } = 3000;

    /// <summary>
    /// \if KO
    /// <para>논리 스테이션 번호를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the logical station number.</para>
    /// \endif
    /// </summary>
    public int StationNumber { get; set; }
}
