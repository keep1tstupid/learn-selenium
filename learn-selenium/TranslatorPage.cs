using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace learn_selenium
{
    class TranslatorPage
    {
        private IWebDriver _driver;

        public TranslatorPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement InputField
        {
            get
            {
                return _driver.FindElement(By.Id("source"));
            }
        }

        public IWebElement TranslateButton
        {
            get
            {
                return _driver.FindElement(By.Id("gt-submit"));
            }
        }


        public IWebElement TranslationResult        {
            get
            {
                return _driver
                    .FindElement(By.Id("result_box"))
                    .FindElement(By.TagName("span"));
            }
        }



        public void OpenPage()
        {
            _driver.Navigate().GoToUrl("https://translate.google.com/");
        }


        public void TranslateText(string text)
        {
            InputField.SendKeys(text);
            TranslateButton.Click();
        }

        public string TranslatedText()
        {
            return TranslationResult.Text;
        }
    }
}
