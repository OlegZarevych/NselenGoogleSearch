using NUnit.Framework;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static NSelene.Selene;
using OpenQA.Selenium.Firefox;

namespace NselenGoogleSearch.Core
{
    public class TestBase
    {
        [SetUp]
        public void InitDriver()
        {
            SetWebDriver(new FirefoxDriver());
        }

        [TearDown]
        public void TeardownDriver()
        {
            GetWebDriver().Quit();
        }
    }
}
