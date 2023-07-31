using sandbox_c_sharp;
using Xunit.Sdk;

namespace sandbox_c_sharp_xunit;

public class UnitTest1
{
    private readonly SomeSut sut = new SomeSut();

    [Fact]
    public void Test1()
    {
        Assert.Equal(4, sut.calculate(2, 2));
    }
}