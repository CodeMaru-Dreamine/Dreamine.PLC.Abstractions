using Dreamine.PLC.Abstractions.Devices;
using Dreamine.PLC.Abstractions.Requests;

namespace Dreamine.PLC.Abstractions.Tests;

public sealed class PlcRequestTests
{
    private static readonly PlcAddress Address = new(PlcDeviceType.D, 100);

    [Fact]
    public void ReadRequest_ExposesAddressAndCount()
    {
        var request = new PlcReadRequest(Address, 4);

        Assert.Equal(Address, request.Address);
        Assert.Equal(4, request.Count);
    }

    [Fact]
    public void BitWriteRequest_ExposesOriginalValues()
    {
        bool[] values = [true, false, true];
        var request = new PlcWriteBitRequest(Address, values);

        Assert.Equal(Address, request.Address);
        Assert.Same(values, request.Values);
    }

    [Fact]
    public void BitWriteRequest_RejectsNullValues()
    {
        Assert.Throws<ArgumentNullException>(() => new PlcWriteBitRequest(Address, null!));
    }

    [Fact]
    public void WordWriteRequest_ExposesOriginalValues()
    {
        short[] values = [10, -3, 25];
        var request = new PlcWriteWordRequest(Address, values);

        Assert.Equal(Address, request.Address);
        Assert.Same(values, request.Values);
    }

    [Fact]
    public void WordWriteRequest_RejectsNullValues()
    {
        Assert.Throws<ArgumentNullException>(() => new PlcWriteWordRequest(Address, null!));
    }
}
