using HW21.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21.Tests
{
    internal class OpenPageTest : BaseTest
    {
        [Test]
        public void OpenMainPageTest()
        {
            //Assert.Pass();
        }
        [Test]
        public void GoToAlertFrameWindowsPageTest() 
        {            
            MainPage.GoToAlertFrameWindowsPage();
            Thread.Sleep(5000);
        }
        [Test]
        public void GoToAlertPage() 
        {
            MainPage.GoToAlertFrameWindowsPage();
            MainPage.GoToAlertPage();
            Thread.Sleep(5000);
        }
    }
}
