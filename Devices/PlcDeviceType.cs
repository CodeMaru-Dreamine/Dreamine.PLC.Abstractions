namespace Dreamine.PLC.Abstractions.Devices;

/// <summary>
/// \if KO
/// <para>공통 PLC 디바이스 메모리 영역을 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines common PLC device memory areas.</para>
/// \endif
/// </summary>
public enum PlcDeviceType
{
    /// <summary>
    /// \if KO
    /// <para>알 수 없거나 지원되지 않는 디바이스입니다.</para>
    /// \endif
    /// \if EN
    /// <para>An unknown or unsupported device type.</para>
    /// \endif
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// \if KO
    /// <para>Mitsubishi 또는 일반 데이터 레지스터 영역입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The Mitsubishi or general data-register area.</para>
    /// \endif
    /// </summary>
    D,

    /// <summary>
    /// \if KO
    /// <para>내부 릴레이 영역입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The internal relay area.</para>
    /// \endif
    /// </summary>
    M,

    /// <summary>
    /// \if KO
    /// <para>입력 릴레이 영역입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The input relay area.</para>
    /// \endif
    /// </summary>
    X,

    /// <summary>
    /// \if KO
    /// <para>출력 릴레이 영역입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The output relay area.</para>
    /// \endif
    /// </summary>
    Y,

    /// <summary>
    /// \if KO
    /// <para>링크 릴레이 영역입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The link relay area.</para>
    /// \endif
    /// </summary>
    B,

    /// <summary>
    /// \if KO
    /// <para>링크 레지스터 영역입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The link-register area.</para>
    /// \endif
    /// </summary>
    W,

    /// <summary>
    /// \if KO
    /// <para>유지 레지스터 영역입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The retentive-register area.</para>
    /// \endif
    /// </summary>
    R,

    /// <summary>
    /// \if KO
    /// <para>파일 레지스터 영역입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The file-register area.</para>
    /// \endif
    /// </summary>
    ZR
}
