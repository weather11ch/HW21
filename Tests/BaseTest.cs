using HW21.Factories;
using HW21.Pages;

namespace HW21.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {            
            MainPage.OpenMainPage();
            Thread.Sleep(5000);
        }
        [TearDown]
        public void TearDown()
        {            
            Driver.QuitDriver();            
        }

    }
}
