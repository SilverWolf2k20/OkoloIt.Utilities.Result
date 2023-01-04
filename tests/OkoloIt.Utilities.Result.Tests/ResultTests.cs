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

            Assert.IsFalse(result.Success);
            Assert.IsTrue(result.Error);
            Assert.IsFalse(string.IsNullOrEmpty(result.Message));
        }

        [Test]
        public void Fail_MessageValueError_ReturnError()
        {
            IResult<int> result = Result.Fail<int>("Error");

            Assert.IsFalse(result.Success);
            Assert.IsTrue(result.Error);
            Assert.IsFalse(string.IsNullOrEmpty(result.Message));
        }

        [Test]
        public void Fail_SimpleError_ReturnError()
        {
            IResult result = Result.Fail();

            Assert.IsFalse(result.Success);
            Assert.IsTrue(result.Error);
            Assert.IsTrue(string.IsNullOrEmpty(result.Message));
        }

        [Test]
        public void Fail_SimpleValueError_ReturnError()
        {
            IResult<int> result = Result.Fail<int>();

            Assert.IsFalse(result.Success);
            Assert.IsTrue(result.Error);
            Assert.IsTrue(string.IsNullOrEmpty(result.Message));
        }

        [Test]
        public void Ok_MessageOk_ReturnOk()
        {
            IResult result = Result.Ok("Ok");

            Assert.IsTrue(result.Success);
            Assert.IsFalse(result.Error);
            Assert.IsFalse(string.IsNullOrEmpty(result.Message));
        }

        [Test]
        public void Ok_MessageValueOk_ReturnOk()
        {
            IResult<int> result = Result.Ok<int>(default, "Ok");

            Assert.IsTrue(result.Success);
            Assert.IsFalse(result.Error);
            Assert.IsFalse(string.IsNullOrEmpty(result.Message));
            Assert.IsTrue(result.Value == default);
        }

        [Test]
        public void Ok_SimpleOk_ReturnOk()
        {
            IResult result = Result.Ok();

            Assert.IsTrue(result.Success);
            Assert.IsFalse(result.Error);
            Assert.IsTrue(string.IsNullOrEmpty(result.Message));
        }

        [Test]
        public void Ok_SimpleValueOk_ReturnOk()
        {
            IResult<int> result = Result.Ok<int>(default);

            Assert.IsTrue(result.Success);
            Assert.IsFalse(result.Error);
            Assert.IsTrue(string.IsNullOrEmpty(result.Message));
            Assert.IsTrue(result.Value == default);
        }

        #endregion Public Methods
    }
}
