using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace learn_selenium
{
    class SearchPage
    {
        private IWebDriver _driver;

        public SearchPage(IWebDriver driver)
        {
            _driver = driver;
        }



        public IWebElement SearchField
        {
            get
            {
                return _driver.FindElement(By.Id("lst-ib"));
            }
        }

        public IWebElement SearchButton
        {
            get
            {
                return _driver.FindElement(By.Name("btnK"));
            }
        }

        public IList<IWebElement> SearchResults
        {
            get {
                return _driver.FindElements(By.ClassName("r"));
            }
        }


        public void OpenPage()
        {
            _driver.Navigate().GoToUrl("https://www.google.ru");
        }

        public void FindText(string text)
        {
            SearchField.SendKeys(text);
            SearchField.SendKeys(Keys.Enter);
        }

        public int SearchResultsCount()
        {
            return SearchResults.Count();
        }
    } 
}
