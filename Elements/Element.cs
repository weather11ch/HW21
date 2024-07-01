using HW21.Factories;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21.Elements
{
    internal class Element
    {
        private readonly By? _locator;
        private Actions actions = new Actions(Driver.GetDriver());

        public Element(By locator) => _locator = locator;        

        public IWebElement WebElement
        {
            get
            {
                WaitWebElementPresent();
                return Driver.GetDriver().FindElement(_locator);
            }
        }
        public void WaitWebElementPresent() => Driver.GetWait(Driver.GetDriver()).Until(drv => drv.FindElements(_locator).Count() > 0);

        public void Click()
        {            
            WebElement.Click();
        }
        public static void AcceptAlert()
        {
            var alert = Driver.GetDriver().SwitchTo().Alert();
            alert.Accept(); alert.Dismiss();
        }
        public static void CancelAlert() 
        {
            var alert = Driver.GetDriver().SwitchTo().Alert();
            alert.Dismiss();
        }
        public void GetText()
        {
            string text = WebElement.Text;
            return;
        }
        //public string GetElementText(out string text)
        //{
        //    text = WebElement.Text;
        //}


        public static bool IsAlertShown()
        {
            try
            {
                Driver.GetDriver().SwitchTo().Alert();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
