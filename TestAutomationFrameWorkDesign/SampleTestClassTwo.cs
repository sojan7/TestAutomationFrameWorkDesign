using Framework_Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FunctionalTests
{
    [TestFixture]
    [Parallelizable]
    public class SampleTestClassTwo : Browser
    {
        private readonly IWebDriver? driver;

        public SampleTestClassTwo()
        {
            driver = GenerateBrowserDriverBasedOnABrowserName("Chrome");
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            driver!.Navigate().GoToUrl("https://www.geeksforgeeks.org/software-testing-basics/");
            Thread.Sleep(TimeSpan.FromSeconds(40));
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