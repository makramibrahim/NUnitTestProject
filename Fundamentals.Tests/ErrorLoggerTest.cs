using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Fundamentals.Tests
{
    [TestFixture]
    class ErrorLoggerTest
    {
        [Test]
        public void Log_NotNullorWhiteSpace_Pass()
        {
            var _logger = new ErrorLogger();

            _logger.Log("a");

            Assert.That(_logger.LastError, Is.EqualTo("a"));

        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void Log_NullorWhiteSpace_ThrowError(string a)
        {
            var _logger = new ErrorLogger();
            Assert.That(() => _logger.Log(a) , Throws.Exception);

        }
    }
}
