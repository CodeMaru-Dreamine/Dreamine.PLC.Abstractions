using Dreamine.PLC.Abstractions.Devices;

namespace Dreamine.PLC.Abstractions.Tests;

public sealed class PlcAddressTests
{
    [Fact]
    public void WordAddress_FormatsWithoutBitOffset()
    {
        var address = new PlcAddress(PlcDeviceType.D, 120);

        Assert.False(address.IsBitAddress);
        Assert.Equal("D120", address.ToString());
    }

    [Fact]
    public void BitAddress_FormatsWithBitOffset()
    {
        var address = new PlcAddress(PlcDeviceType.M, 42, 7);

        Assert.True(address.IsBitAddress);
        Assert.Equal("M42.7", address.ToString());
    }

    [Fact]
    public void Address_IsAValueTypeWithStructuralEquality()
    {
        var first = new PlcAddress(PlcDeviceType.ZR, 10, 2);
        var second = new PlcAddress(PlcDeviceType.ZR, 10, 2);

        Assert.Equal(first, second);
    }
}
