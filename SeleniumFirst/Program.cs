using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");


            IWebElement element = driver.FindElement(By.Name("q"));

            element.SendKeys("executeaotumation");

            driver.Close();

        }
    }
}
