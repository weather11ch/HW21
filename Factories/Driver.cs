using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HW21.Factories
{
    public class Driver
    {
        public static IWebDriver? _driver;

        public static WebDriverWait? _wait;
        private static IWebDriver SetupDriver() => _driver ??= new ChromeDriver();
        public static IWebDriver GetDriver() => _driver ??= SetupDriver();
        public static WebDriverWait WaitDriver(IWebDriver driver, double waitTime) => _wait ??= new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
       public static WebDriverWait GetWait(IWebDriver driver, double waitTime = 30) => _wait ??= new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));

        //обнуление драйвера
        public static void QuitDriver()
        {
            _driver.Close();
            _driver.Quit();
            _driver = null;
            _wait = null;
        }
        public static void CloseDriver()
        {
            _driver.Close();

        }
    }
}
