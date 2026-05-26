namespace Dreamine.PLC.Abstractions.Results;

/// <summary>
/// Represents the result of a PLC operation with a value.
/// </summary>
/// <typeparam name="T">The result value type.</typeparam>
public sealed class PlcResult<T> : PlcResult
{
    private PlcResult(bool isSuccess, T? value, int? errorCode, string? message)
        : base(isSuccess, errorCode, message)
    {
        Value = value;
    }

    /// <summary>
    /// Gets the result value.
    /// </summary>
    public T? Value { get; }

    /// <summary>
    /// Creates a successful PLC result with a value.
    /// </summary>
    /// <param name="value">The result value.</param>
    /// <returns>A successful PLC result.</returns>
    public static PlcResult<T> Success(T value)
    {
        return new PlcResult<T>(true, value, null, null);
    }

    /// <summary>
    /// Creates a failed PLC result.
    /// </summary>
    /// <param name="message">The failure message.</param>
    /// <param name="errorCode">The optional error code.</param>
    /// <returns>A failed PLC result.</returns>
    public new static PlcResult<T> Failure(string message, int? errorCode = null)
    {
        return new PlcResult<T>(false, default, errorCode, message);
    }
}