using System;
using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{

    [TestFixture]
    [Category("TestCase")]
    public class UnitTest10393
    {
        private readonly PrimeService _primeService;

        public UnitTest10393()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void ReturnFalseGivenValueOf2()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from TestContext");
            
            var result = _primeService.IsPrime(2);

            Assert.IsFalse(result, $"2 should not be prime");
        }
        
        [Test]
        [Ignore("temporary ignored test")]
        public void IgnoredTest()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from TestContext");
            
            var result = _primeService.IsPrime(2);

            Assert.IsFalse(result, $"2 should not be prime");
        }
    }
}
