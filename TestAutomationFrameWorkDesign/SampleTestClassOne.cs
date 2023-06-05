using FrameworkCore;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FunctionalTests
{
    [TestFixture]
    [Parallelizable]
    public class SampleTestClassOne : Browser
    {
        private readonly IWebDriver? driver;

        public SampleTestClassOne()
        {
            driver = GenerateBrowserDriverBasedOnABrowserName("Chrome");
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            driver!.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(TimeSpan.FromSeconds(30));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver!.Quit();
        }

        [Test]
        [Category("Sample Tests")]
        public void Test2Function()
        {
            int testNumber = 500;
            Assert.That(testNumber.Equals(500));
        }
    }
}