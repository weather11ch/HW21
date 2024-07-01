using HW21.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21.Tests
{
    internal class AlertPageTests : BaseTest
    {
        [Test]
        public void OpenAlertPageTests()
        {
            AlertPage.OpenAlertPage();
            Thread.Sleep(1000);    
        }
        [Test]
        public void CloseFirstAlert()
        {
            AlertPage.OpenAlertPage();
            AlertPage.OpenFirstAlert();
            AlertPage.AceptAndCloseAlert();
            var result = AlertPage.CheckAlert();
            Assert.That(result, Is.False);
        }
        [Test]
        public void CloseSecondAlert()
        {
            AlertPage.OpenAlertPage();
            AlertPage.OpenSecondAlert();
            Thread.Sleep(5000);
            AlertPage.AceptAndCloseAlert();
            var result = AlertPage.CheckAlert();
            Assert.That(result, Is.False);
        }
        [Test]
        public void ThirdAlertTest1()
        {
            AlertPage.OpenAlertPage();
            AlertPage.OpenThirdAlert();
            Thread.Sleep(1000);
            AlertPage.CancelAndCloseAlert();
            Thread.Sleep(5000);
        }
    }
}
