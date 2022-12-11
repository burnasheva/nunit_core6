using System;
using System.Threading;
using NUnit.Framework;

namespace Prime.UnitTests.Services
{
    [TestFixture, Explicit]
    public class CheckAssumeCase5
    {
        [Test]
        [Category("Simple")]
        public void TestAssumeFalse()
        {
            Thread.Sleep(500);Assume.That(false);
        }

        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo1(String browser, String version, String os)
        {
            Thread.Sleep(500);Assert.Equals(browser, version);
        }
        
        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo2(String browser, String version, String os)
        {
            Thread.Sleep(500);Assert.Equals(browser, version);
        }
        
        
        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo3(String browser, String version, String os)
        {
            Thread.Sleep(500);Assert.Equals(browser, version);
        }
        
        
        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo4(String browser, String version, String os)
        {
            Thread.Sleep(500);Assert.Equals(browser, version);
        }
        
        
        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo5(String browser, String version, String os)
        {
            Thread.Sleep(500);Assert.Equals(browser, version);
        }
        
        
        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo6(String browser, String version, String os)
        {
            Thread.Sleep(500);Assert.Equals(browser, version);
        }
        
        
        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo7(String browser, String version, String os)
        {
            Thread.Sleep(500); Assert.Equals(browser, version);
        }
        
        
        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo8(String browser, String version, String os)
        {
            Thread.Sleep(500);Assert.Equals(browser, version);
        }
        
        
        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo9(String browser, String version, String os)
        {
            Thread.Sleep(500);Assert.Equals(browser, version);
        }
        
        
        [Test]
        [TestCase("chrome", "72", "Windows 10")]
        [TestCase("internet explorer", "11.0", "Windows 10")]
        [TestCase("Safari", "11.0", "macOS High Sierra")]
        [TestCase("Microsoft Edge", "18.0", "Windows 10")]
        public void DuckDuckGo_TestCase_Demo10(String browser, String version, String os)
        {
            Thread.Sleep(500);Assert.Equals(browser, version);
        }
    }
}