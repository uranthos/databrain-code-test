namespace DataBrain.PAYG.Tests;
using DataBrain.PAYG;

public class PAYGServiceTests
{
    [Fact]
    public void Test1()
    {
        var service = new PAYGService();
        var payg = service.GetTax(4807.69f, PaymentFrequency.Fortnightly);
        Assert.True(payg > 0);
    }
}