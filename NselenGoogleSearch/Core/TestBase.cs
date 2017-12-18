using NUnit.Framework;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static NSelene.Selene;

namespace NselenGoogleSearch.Core
{
    public class TestBase
    {
        [SetUp]
        public void InitDriver()
        {
            SetWebDriver(new ChromeDriver());
        }

        [TearDown]
        public void TeardownDriver()
        {
            GetWebDriver().Quit();
        }
    }
}
