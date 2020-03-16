using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumFirst
{
    class Program
    {

        IWebDriver driver = new ChromeDriver();
        private static void Main(string[] args) {

        }
        [SetUp]
        public void Initialize(){
            driver.Navigate().GoToUrl("https://www.google.com");
            System.Console.WriteLine("fff");
        }

        [Test]
        public void ExcuteTest(){
            IWebElement search = driver.FindElement(By.Name("q"));
            search.SendKeys("morfix");
            Thread.Sleep(2000);

        }
        [TearDown]
        public void CleanUp() {
            driver.Close();
        }
    }
}
