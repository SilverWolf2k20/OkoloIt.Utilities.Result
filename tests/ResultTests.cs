using NUnit.Framework;

namespace OkoloIt.Utilities.Result.Tests;

[TestFixture]
internal sealed class ResultTests
{
    #region Public Methods

    [Test]
    public void Fail_MessageError_ReturnError()
    {
        Result<int> result = Result.Fail("Error");

        Assert.Multiple(() => {
            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.True);
            Assert.That(string.IsNullOrEmpty(result.Message), Is.False);
        });
    }

    [Test]
    public void Ok_SimpleValueOk_ReturnOk()
    {
        Result<int> result = Result.Ok(7);
        
        Assert.Multiple(() => {
            Assert.That(result.Success, Is.True);
            Assert.That(result.Error, Is.False);
            Assert.That(string.IsNullOrEmpty(result.Message), Is.True);
            Assert.That(result.Value == default, Is.True);
        });
    }

    #endregion Public Methods
}
