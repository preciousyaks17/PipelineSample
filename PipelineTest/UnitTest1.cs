using NUnit.Framework;
using PipelineSample.Services;
namespace PipelineTest;

[TestFixture]
public class PipelineTests
{
    private Pipeline _pipeline;

    [SetUp]
    public void SetUp()
    {
        _pipeline = new Pipeline();
    }

    [Test]
    public void Add_WhenCalled_ReturnsTheSumOfArguments()
    {
        var result = _pipeline.Add(1, 2);

        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void ValidateDeposit_WithPositiveAmount_ReturnsTrue()
    {
        var result = _pipeline.ValidateDeposit(100m);

        Assert.That(result, Is.True);
    }

    [Test]
    public void ValidateDeposit_WithZeroOrNegativeAmount_ReturnsFalse()
    {
        var result = _pipeline.ValidateDeposit(-100m);

        Assert.That(result, Is.False);
    }

    [Test]
    public void ValidateWithdraw_WithAmountLessThanOrEqualToBalance_ReturnsTrue()
    {
        var result = _pipeline.ValidateWithdraw(100m, 200m);

        Assert.That(result, Is.True);
    }

    [Test]
    public void ValidateWithdraw_WithAmountGreaterThanBalance_ReturnsFalse()
    {
        var result = _pipeline.ValidateWithdraw(300m, 200m);

        Assert.That(result, Is.False);
    }
}








