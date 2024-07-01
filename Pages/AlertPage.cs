using HW21.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21.Pages
{
    internal class AlertPage
    {
        public static Element FirstAlertButton = new(By.Id("alertButton"));
        private static Element SecondTimerAlertButton = new(By.Id("timerAlertButton"));
        private static Element ThirdConfirmAlertButton = new(By.Id("confirmButton"));
        private static Element ForthPromtAlertButton = new(By.Id("promtButton"));
        public static void OpenAlertPage()
        {
            string url = "https://demoqa.com/alerts";
            MainPage.OpenPage(url);
        }   
        public static void OpenAlert(Element alertButton) => alertButton.Click();

        public static void OpenFirstAlert()
        {
            OpenAlert(FirstAlertButton);
        }
        public static void OpenSecondAlert()
        {
            OpenAlert(SecondTimerAlertButton);
        }
        public static void OpenThirdAlert()
        {
            OpenAlert(ThirdConfirmAlertButton);
        }
        public static void CancelAndCloseAlert(Element alertButton)
        {
            alertButton.CancelAlert();
            string result = ThirdConfirmAlertButton.GetText();
        }
        public static void CheckCancel(Element alertButton)
        {
            
                }

        public static void AceptAndCloseAlert() => Element.AcceptAlert();

        public static bool CheckAlert() => Element.IsAlertShown();
    }
}
