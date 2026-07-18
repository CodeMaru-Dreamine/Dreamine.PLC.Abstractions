using Dreamine.PLC.Abstractions.Devices;

namespace Dreamine.PLC.Abstractions.Requests;

/// <summary>
/// \if KO
/// <para>PLC 워드 쓰기 요청을 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents a PLC word-write request.</para>
/// \endif
/// </summary>
public sealed class PlcWriteWordRequest
{
    /// <summary>
    /// \if KO
    /// <para>주소와 워드 값으로 <see cref="T:Dreamine.PLC.Abstractions.Requests.PlcWriteWordRequest" />를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes <see cref="T:Dreamine.PLC.Abstractions.Requests.PlcWriteWordRequest" /> with an address and word values.</para>
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
    /// <exception cref="ArgumentNullException">
    /// \if KO
    /// <para><paramref name="values"/>가 <see langword="null"/>인 경우 발생합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Thrown when <paramref name="values"/> is <see langword="null"/>.</para>
    /// \endif
    /// </exception>
    public PlcWriteWordRequest(PlcAddress address, IReadOnlyList<short> values)
    {
        Address = address;
        Values = values ?? throw new ArgumentNullException(nameof(values));
    }

    /// <summary>
    /// \if KO
    /// <para>시작 PLC 주소를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the start PLC address.</para>
    /// \endif
    /// </summary>
    public PlcAddress Address { get; }

    /// <summary>
    /// \if KO
    /// <para>쓸 워드 값을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the word values to write.</para>
    /// \endif
    /// </summary>
    public IReadOnlyList<short> Values { get; }
}
