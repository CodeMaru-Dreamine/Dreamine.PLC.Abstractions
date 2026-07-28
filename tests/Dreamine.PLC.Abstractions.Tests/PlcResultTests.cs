using Dreamine.PLC.Abstractions.Results;

namespace Dreamine.PLC.Abstractions.Tests;

public sealed class PlcResultTests
{
    [Fact]
    public void Success_CreatesSuccessfulResult()
    {
        var result = PlcResult.Success();

        Assert.True(result.IsSuccess);
        Assert.Null(result.ErrorCode);
        Assert.Null(result.Message);
    }

    [Fact]
    public void Failure_CarriesErrorDetails()
    {
        var result = PlcResult.Failure("Connection failed.", 503);

        Assert.False(result.IsSuccess);
        Assert.Equal(503, result.ErrorCode);
        Assert.Equal("Connection failed.", result.Message);
    }

    [Theory]
    [InlineData("")]
    [InlineData("  ")]
    public void Failure_RejectsBlankMessages(string message)
    {
        Assert.Throws<ArgumentException>(() => PlcResult.Failure(message));
    }

    [Fact]
    public void GenericSuccess_CarriesValue()
    {
        var result = PlcResult<int[]>.Success([1, 2, 3]);

        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Value);
        Assert.Equal([1, 2, 3], result.Value);
        Assert.Null(result.Message);
    }

    [Fact]
    public void GenericFailure_CarriesErrorAndNoValue()
    {
        var result = PlcResult<string>.Failure("Read failed.", 17);

        Assert.False(result.IsSuccess);
        Assert.Null(result.Value);
        Assert.Equal(17, result.ErrorCode);
        Assert.Equal("Read failed.", result.Message);
    }

    [Theory]
    [InlineData("")]
    [InlineData("\t")]
    public void GenericFailure_RejectsBlankMessages(string message)
    {
        Assert.Throws<ArgumentException>(() => PlcResult<string>.Failure(message));
    }
}
