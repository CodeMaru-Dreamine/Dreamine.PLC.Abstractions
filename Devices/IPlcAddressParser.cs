using Dreamine.PLC.Abstractions.Results;

namespace Dreamine.PLC.Abstractions.Devices;

/// <summary>
/// \if KO
/// <para>PLC 주소 텍스트를 구조화된 주소로 변환하는 파서를 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines a parser that converts PLC address text into a structured address.</para>
/// \endif
/// </summary>
public interface IPlcAddressParser
{
    /// <summary>
    /// \if KO
    /// <para>PLC 주소 텍스트를 구문 분석합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Parses PLC address text.</para>
    /// \endif
    /// </summary>
    /// <param name="text">
    /// \if KO
    /// <para>PLC 주소 텍스트입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The PLC address text.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>구문 분석된 주소 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The parsed PLC address result.</para>
    /// \endif
    /// </returns>
    PlcResult<PlcAddress> Parse(string text);

    /// <summary>
    /// \if KO
    /// <para>PLC 주소 텍스트의 구문 분석을 시도합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Attempts to parse PLC address text.</para>
    /// \endif
    /// </summary>
    /// <param name="text">
    /// \if KO
    /// <para>PLC 주소 텍스트입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The PLC address text.</para>
    /// \endif
    /// </param>
    /// <param name="address">
    /// \if KO
    /// <para>성공 시 구문 분석된 PLC 주소입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The parsed PLC address on success.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>성공하면 <see langword="true"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para><see langword="true"/> when parsing succeeds.</para>
    /// \endif
    /// </returns>
    bool TryParse(string text, out PlcAddress address);
}
