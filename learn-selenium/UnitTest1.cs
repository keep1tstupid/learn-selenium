using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace learn_selenium
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver chromeDriver;

        [AssemblyInitialize]
        public static void SetUp(TestContext context) {
            chromeDriver = new ChromeDriver(@"C:\Users\User\source\repos\learn-selenium\learn-selenium\packages\Selenium.Chrome.WebDriver.2.37\driver");
        }

    
        [TestMethod]
        public void SimpleGoogleSearch()
        {
            SearchPage googleSearch = new SearchPage(chromeDriver);
            googleSearch.OpenPage();
            googleSearch.FindText("pepe");
            Assert.AreEqual(10, googleSearch.SearchResultsCount());
        }

        [TestMethod]
        public void SimpleGoogleTranslate()
        {
            TranslatorPage googleTranslate = new TranslatorPage(chromeDriver);
            googleTranslate.OpenPage();
            googleTranslate.TranslateText("123");
            Assert.AreEqual("123", googleTranslate.TranslatedText());
        }
    }
}
