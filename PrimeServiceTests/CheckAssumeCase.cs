using NUnit.Framework;

namespace Prime.UnitTests.Services
{
    public class CheckAssumeCase
    {
        [Test]
        [Category("Simple")]
        public void TestAssumeFalse()
        {
            Assume.That(false);
        }
    }
}