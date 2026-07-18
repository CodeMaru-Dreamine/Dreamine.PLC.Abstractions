namespace Dreamine.PLC.Abstractions.Results;

/// <summary>
/// \if KO
/// <para>값을 포함한 PLC 작업 결과를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents the result of a PLC operation with a value.</para>
/// \endif
/// </summary>
/// <typeparam name="T">
/// \if KO
/// <para>결과 값 타입입니다.</para>
/// \endif
/// \if EN
/// <para>The result value type.</para>
/// \endif
/// </typeparam>
public sealed class PlcResult<T> : PlcResult
{
    /// <summary>
    /// \if KO
    /// <para>성공 상태, 값, 오류 코드 및 메시지로 결과를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes the result with success state, value, error code, and message.</para>
    /// \endif
    /// </summary>
    /// <param name="isSuccess">
    /// \if KO
    /// <para>성공 여부입니다.</para>
    /// \endif
    /// \if EN
    /// <para>Whether the operation succeeded.</para>
    /// \endif
    /// </param>
    /// <param name="value">
    /// \if KO
    /// <para>결과 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The result value.</para>
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
    /// <para>선택적 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The optional message.</para>
    /// \endif
    /// </param>
    private PlcResult(bool isSuccess, T? value, int? errorCode, string? message)
        : base(isSuccess, errorCode, message)
    {
        Value = value;
    }

    /// <summary>
    /// \if KO
    /// <para>결과 값을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the result value.</para>
    /// \endif
    /// </summary>
    public T? Value { get; }

    /// <summary>
    /// \if KO
    /// <para>값을 포함한 성공 PLC 결과를 만듭니다.</para>
    /// \endif
    /// \if EN
    /// <para>Creates a successful PLC result with a value.</para>
    /// \endif
    /// </summary>
    /// <param name="value">
    /// \if KO
    /// <para>결과 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The result value.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>성공 PLC 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A successful PLC result.</para>
    /// \endif
    /// </returns>
    public static PlcResult<T> Success(T value)
    {
        return new PlcResult<T>(true, value, null, null);
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
    public new static PlcResult<T> Failure(string message, int? errorCode = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(message);
        return new PlcResult<T>(false, default, errorCode, message);
    }
}
