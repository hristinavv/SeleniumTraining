
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTraining;

    public class Tests
    {
         IWebDriver drv;

        [SetUp]
        public void Setup()
        {
            drv = new ChromeDriver();
        }
        [TearDown]
        public void TearDown()
        {

            drv.Quit();
        }
        [Test]
        public void Test1()
        {
            drv.Navigate().GoToUrl("https://google.com");
            drv.FindElement(By.CssSelector("[name=q]")).SendKeys("Selenium");
            drv.FindElement(By.CssSelector("[name=q]")).SendKeys(Keys.Home + "First");
            drv.FindElement(By.CssSelector("[name=q]")).SendKeys("Selenium" + Keys.Enter);
        }
    }

