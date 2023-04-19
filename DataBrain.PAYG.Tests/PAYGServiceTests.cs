namespace DataBrain.PAYG.Tests;

using DataBrain.Common.CommonDefs;
using DataBrain.PAYG;

public class PAYGServiceTests
{
    const float incomeValue = 3850.20f;
    const string failMessage = "value {0} returned. Expected {1}.";

    [Fact]
    public void FortnightlyTest()
    {
        var service = new PAYGService();
        var payg = service.GetTax(incomeValue, PaymentFrequency.Fortnightly);
        //paycalculator returned the value of 964
        Assert.True(payg == 964, string.Format(failMessage, payg, 964));
    }

    [Fact]
    public void WeeklyTest()
    {
        var service = new PAYGService();
        var payg = service.GetTax(incomeValue, PaymentFrequency.Weekly);
        //paycalculator returned the value of 1246
        Assert.True(payg == 1246, string.Format(failMessage, payg, 1246)); 
    }

    [Fact]
    public void MonthlyTest()
    {
        var service = new PAYGService();
        var payg = service.GetTax(incomeValue, PaymentFrequency.Monthly);
        // paycalculator return the value of 533
        Assert.True(payg == 533, string.Format(failMessage, payg, 533)); 
    }

    [Fact]
    public void FourWeeklyTest()
    {
        var service = new PAYGService();
        //float income = (incomeValue / 4);
        var payg = service.GetTax(incomeValue, PaymentFrequency.FourWeekly);
        //paycalculator doesn't list 'four weekly' so we divide our income value '3850.20' by 4 to get the weekly value
        // our result being $149/week * 4 == $596
        Assert.True(payg == 596, string.Format(failMessage, payg, 596));
    }

    [Fact]
    public void InvalidFrequencyTest()
    {
        var service = new PAYGService();
        try {
            var payg = service.GetTax(incomeValue, (PaymentFrequency)4);
            Assert.Fail("Payment frequency is not within range 0 to 3");
        }
        catch (Exception ex) {
            Assert.True(ex is ArgumentException);
        }
    }

    [Fact]
    public void InvalidFrequencyTest2()
    {
        var service = new PAYGService();
        try
        {
            var payg = service.GetTax(incomeValue, (PaymentFrequency)(-1));
            Assert.Fail("Payment frequency is not within range 0 to 3");
        }
        catch (Exception ex)
        {
            Assert.True(ex is ArgumentException);
        }
    }
}