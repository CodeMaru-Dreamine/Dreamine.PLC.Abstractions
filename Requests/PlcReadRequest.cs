using Dreamine.PLC.Abstractions.Devices;

namespace Dreamine.PLC.Abstractions.Requests;

/// <summary>
/// \if KO
/// <para>PLC 읽기 요청을 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents a PLC read request.</para>
/// \endif
/// </summary>
/// <param name="Address">
/// \if KO
/// <para>시작 PLC 주소입니다.</para>
/// \endif
/// \if EN
/// <para>The start PLC address.</para>
/// \endif
/// </param>
/// <param name="Count">
/// \if KO
/// <para>읽을 값 수입니다.</para>
/// \endif
/// \if EN
/// <para>The number of values to read.</para>
/// \endif
/// </param>
public readonly record struct PlcReadRequest(
    PlcAddress Address,
    int Count);
