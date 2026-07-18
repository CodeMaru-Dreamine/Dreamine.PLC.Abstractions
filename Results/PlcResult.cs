namespace Dreamine.PLC.Abstractions.Results;

/// <summary>
/// \if KO
/// <para>PLC 작업 결과를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents the result of a PLC operation.</para>
/// \endif
/// </summary>
public class PlcResult
{
    /// <summary>
    /// \if KO
    /// <para>성공 여부, 오류 코드 및 메시지로 <see cref="T:Dreamine.PLC.Abstractions.Results.PlcResult" />를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes <see cref="T:Dreamine.PLC.Abstractions.Results.PlcResult" /> with success state, error code, and message.</para>
    /// \endif
    /// </summary>
    /// <param name="isSuccess">
    /// \if KO
    /// <para>작업 성공 여부입니다.</para>
    /// \endif
    /// \if EN
    /// <para>Whether the operation succeeded.</para>
    /// \endif
    /// </param>
    /// <param name="errorCode">
    /// \if KO
    /// <para>선택적 오류 코드입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The optional error code.</para>
    /// \endif
    /// </param>
    /// <param name="message">
    /// \if KO
    /// <para>선택적 결과 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The optional result message.</para>
    /// \endif
    /// </param>
    protected PlcResult(bool isSuccess, int? errorCode, string? message)
    {
        IsSuccess = isSuccess;
        ErrorCode = errorCode;
        Message = message;
    }

    /// <summary>
    /// \if KO
    /// <para>작업 성공 여부를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets whether the operation succeeded.</para>
    /// \endif
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// \if KO
    /// <para>선택적 PLC 또는 어댑터 오류 코드를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the optional PLC or adapter error code.</para>
    /// \endif
    /// </summary>
    public int? ErrorCode { get; }

    /// <summary>
    /// \if KO
    /// <para>선택적 결과 메시지를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the optional result message.</para>
    /// \endif
    /// </summary>
    public string? Message { get; }

    /// <summary>
    /// \if KO
    /// <para>성공 PLC 결과를 만듭니다.</para>
    /// \endif
    /// \if EN
    /// <para>Creates a successful PLC result.</para>
    /// \endif
    /// </summary>
    /// <returns>
    /// \if KO
    /// <para>성공 PLC 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A successful PLC result.</para>
    /// \endif
    /// </returns>
    public static PlcResult Success()
    {
        return new PlcResult(true, null, null);
    }

    /// <summary>
    /// \if KO
    /// <para>실패 PLC 결과를 만듭니다.</para>
    /// \endif
    /// \if EN
    /// <para>Creates a failed PLC result.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>실패 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The failure message.</para>
    /// \endif
    /// </param>
    /// <param name="errorCode">
    /// \if KO
    /// <para>선택적 오류 코드입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The optional error code.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>실패 PLC 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A failed PLC result.</para>
    /// \endif
    /// </returns>
    /// <exception cref="ArgumentException">
    /// \if KO
    /// <para><paramref name="message"/>가 비어 있는 경우 발생합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Thrown when <paramref name="message"/> is empty.</para>
    /// \endif
    /// </exception>
    public static PlcResult Failure(string message, int? errorCode = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(message);
        return new PlcResult(false, errorCode, message);
    }
}
