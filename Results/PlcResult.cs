namespace Dreamine.PLC.Abstractions.Results;

/// <summary>
/// Represents the result of a PLC operation.
/// </summary>
public class PlcResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlcResult"/> class.
    /// </summary>
    /// <param name="isSuccess">Whether the operation succeeded.</param>
    /// <param name="errorCode">The optional PLC or adapter error code.</param>
    /// <param name="message">The optional result message.</param>
    protected PlcResult(bool isSuccess, int? errorCode, string? message)
    {
        IsSuccess = isSuccess;
        ErrorCode = errorCode;
        Message = message;
    }

    /// <summary>
    /// Gets whether the operation succeeded.
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// Gets the optional PLC or adapter error code.
    /// </summary>
    public int? ErrorCode { get; }

    /// <summary>
    /// Gets the optional result message.
    /// </summary>
    public string? Message { get; }

    /// <summary>
    /// Creates a successful PLC result.
    /// </summary>
    /// <returns>A successful PLC result.</returns>
    public static PlcResult Success()
    {
        return new PlcResult(true, null, null);
    }

    /// <summary>
    /// Creates a failed PLC result.
    /// </summary>
    /// <param name="message">The failure message.</param>
    /// <param name="errorCode">The optional error code.</param>
    /// <returns>A failed PLC result.</returns>
    public static PlcResult Failure(string message, int? errorCode = null)
    {
        return new PlcResult(false, errorCode, message);
    }
}