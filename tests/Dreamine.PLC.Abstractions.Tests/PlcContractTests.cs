using Dreamine.PLC.Abstractions.Connections;
using Dreamine.PLC.Abstractions.Devices;
using Dreamine.PLC.Abstractions.Options;

namespace Dreamine.PLC.Abstractions.Tests;

public sealed class PlcContractTests
{
    [Fact]
    public void ConnectionOptions_HaveSafeDefaults()
    {
        var options = new PlcConnectionOptions();

        Assert.Equal(string.Empty, options.Host);
        Assert.Equal(0, options.Port);
        Assert.Equal(3000, options.ConnectTimeoutMs);
        Assert.Equal(3000, options.ReadTimeoutMs);
        Assert.Equal(3000, options.WriteTimeoutMs);
        Assert.Equal(0, options.StationNumber);
    }

    [Fact]
    public void ConnectionOptions_AreMutableConfiguration()
    {
        var options = new PlcConnectionOptions
        {
            Host = "192.0.2.10",
            Port = 5000,
            ConnectTimeoutMs = 1000,
            ReadTimeoutMs = 1500,
            WriteTimeoutMs = 2000,
            StationNumber = 3
        };

        Assert.Equal("192.0.2.10", options.Host);
        Assert.Equal(5000, options.Port);
        Assert.Equal(1000, options.ConnectTimeoutMs);
        Assert.Equal(1500, options.ReadTimeoutMs);
        Assert.Equal(2000, options.WriteTimeoutMs);
        Assert.Equal(3, options.StationNumber);
    }

    [Fact]
    public void PublicEnumValues_RemainStable()
    {
        Assert.Equal(0, (int)PlcConnectionState.Disconnected);
        Assert.Equal(4, (int)PlcConnectionState.Faulted);
        Assert.Equal(0, (int)PlcDeviceType.Unknown);
        Assert.Equal(9, Enum.GetValues<PlcDeviceType>().Length);
    }
}
