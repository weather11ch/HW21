using HW21.Elements;
using HW21.Factories;
using HW21.Tests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21.Pages
{
    internal class MainPage
    {
        private static Element alertFrameWindowPage = new(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[3]"));
        private static Element alertPageButton = new(By.XPath("//*[@class = 'text']/text()[. ='Alerts']"));
        //*[@class='left-pannel']
        public static void OpenPage(string url)
        {
            Driver.GetDriver().Navigate().GoToUrl($"{url}");
            Driver.GetDriver().Manage().Window.Maximize();
        }

        public static void OpenMainPage()
        {
            string url = "https://demoqa.com/";            
            OpenPage(url);
        }        
        public static void GoToAlertFrameWindowsPage() 
        {            
            alertFrameWindowPage.WaitWebElementPresent();
            alertFrameWindowPage.Click();
        }
        public static void GoToAlertPage()
        {
            alertPageButton.WaitWebElementPresent();
            alertPageButton.Click();
        }

    }
}
//*[@class = 'text']
//*[contains(@class, 'test-3')]
//*[@id="item-1"]
//*[@class = 'text']/text()[. ='Alerts']