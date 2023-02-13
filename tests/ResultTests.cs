using NUnit.Framework;

namespace OkoloIt.Utilities.Result.Tests
{
    [TestFixture]
    internal class ResultTests
    {
        #region Public Methods

        [Test]
        public void Fail_MessageError_ReturnError()
        {
            IResult result = Result.Fail("Error");
            
            Assert.Multiple(() => {
                Assert.That(result.Success, Is.False);
                Assert.That(result.Error, Is.True);
                Assert.That(string.IsNullOrEmpty(result.Message), Is.False);
            });
        }

        [Test]
        public void Fail_MessageValueError_ReturnError()
        {
            IResult<int> result = Result.Fail<int>("Error");

            Assert.Multiple(() => {
                Assert.That(result.Success, Is.False);
                Assert.That(result.Error, Is.True);
                Assert.That(string.IsNullOrEmpty(result.Message), Is.False);
            });
        }

        [Test]
        public void Fail_SimpleError_ReturnError()
        {
            IResult result = Result.Fail();

            Assert.Multiple(() => {
                Assert.That(result.Success, Is.False);
                Assert.That(result.Error, Is.True);
                Assert.That(string.IsNullOrEmpty(result.Message), Is.True);
            });
        }

        [Test]
        public void Fail_SimpleValueError_ReturnError()
        {
            IResult<int> result = Result.Fail<int>();
            
            Assert.Multiple(() => {
                Assert.That(result.Success, Is.False);
                Assert.That(result.Error, Is.True);
                Assert.That(string.IsNullOrEmpty(result.Message), Is.True);
            });
        }

        [Test]
        public void Ok_MessageOk_ReturnOk()
        {
            IResult result = Result.Ok("Ok");

            Assert.Multiple(() => {
                Assert.That(result.Success, Is.True);
                Assert.That(result.Error, Is.False);
                Assert.That(string.IsNullOrEmpty(result.Message), Is.False);
            });
        }

        [Test]
        public void Ok_MessageValueOk_ReturnOk()
        {
            IResult<int> result = Result.Ok<int>(default, "Ok");
            
            Assert.Multiple(() => {
                Assert.That(result.Success, Is.True);
                Assert.That(result.Error, Is.False);
                Assert.That(string.IsNullOrEmpty(result.Message), Is.False);
                Assert.That(result.Value == default, Is.True);
            });
        }

        [Test]
        public void Ok_SimpleOk_ReturnOk()
        {
            IResult result = Result.Ok();
            
            Assert.Multiple(() => {
                Assert.That(result.Success, Is.True);
                Assert.That(result.Error, Is.False);
                Assert.That(string.IsNullOrEmpty(result.Message), Is.True);
            });
        }

        [Test]
        public void Ok_SimpleValueOk_ReturnOk()
        {
            IResult<int> result = Result.Ok<int>(default);
            
            Assert.Multiple(() => {
                Assert.That(result.Success, Is.True);
                Assert.That(result.Error, Is.False);
                Assert.That(string.IsNullOrEmpty(result.Message), Is.True);
                Assert.That(result.Value == default, Is.True);
            });
        }

        #endregion Public Methods
    }
}
