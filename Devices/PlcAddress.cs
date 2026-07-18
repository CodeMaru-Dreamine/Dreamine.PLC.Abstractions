namespace Dreamine.PLC.Abstractions.Devices;

/// <summary>
/// \if KO
/// <para>PLC 디바이스 주소를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents a PLC device address.</para>
/// \endif
/// </summary>
/// <param name="DeviceType">
/// \if KO
/// <para>PLC 디바이스 메모리 타입입니다.</para>
/// \endif
/// \if EN
/// <para>The PLC device memory type.</para>
/// \endif
/// </param>
/// <param name="Offset">
/// \if KO
/// <para>디바이스 오프셋입니다.</para>
/// \endif
/// \if EN
/// <para>The device offset.</para>
/// \endif
/// </param>
/// <param name="BitOffset">
/// \if KO
/// <para>비트 접근용 선택적 오프셋입니다.</para>
/// \endif
/// \if EN
/// <para>The optional bit offset for bit-level access.</para>
/// \endif
/// </param>
public readonly record struct PlcAddress(
    PlcDeviceType DeviceType,
    int Offset,
    int? BitOffset = null)
{
    /// <summary>
    /// \if KO
    /// <para>이 주소가 비트 수준 주소인지 여부를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets whether this address points to a bit-level device.</para>
    /// \endif
    /// </summary>
    public bool IsBitAddress => BitOffset.HasValue;

    /// <summary>
    /// \if KO
    /// <para>주소를 읽기 쉬운 문자열로 반환합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Returns the address as a readable string.</para>
    /// \endif
    /// </summary>
    /// <returns>
    /// \if KO
    /// <para>서식이 적용된 PLC 주소입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The formatted PLC address.</para>
    /// \endif
    /// </returns>
    public override string ToString()
    {
        return BitOffset.HasValue
            ? $"{DeviceType}{Offset}.{BitOffset.Value}"
            : $"{DeviceType}{Offset}";
    }
}
