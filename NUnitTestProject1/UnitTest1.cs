using NUnit.Framework;
using NUnitTestProject1.PageObjects;
using NUnitTestProject1.ProjectOrange;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1
{
    public class Tests
    {

        [OneTimeSetUp]
        public void Setup()
        {
            PropertiesClass.driver = new ChromeDriver();
            PropertiesClass.driver.Manage().Window.Maximize();
            PropertiesClass.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/login");
        }

        

        [Test, Order(1)]
        public void TestLogin()
        {
            OrangeHrm.LoginMthd("Admin", "admin123");
        }

        [Test, Order(2)]
        public void TestRecrt()
        {
            OrangeHrm.RecMthd();
        }

        [Test, Order(3)]
        public void TestAdd()
        {
            OrangeHrm.AddMthd();
            Assert.Pass();
        }

        [Test, Order(4)]
        public void TestEdit()
        {
            OrangeHrm.EditMthd();
        }

        [Test, Order(5)]
        public void TestDelete()
        {
            OrangeHrm.DeleteMthd();
        }


        [OneTimeTearDown]
        public void clear()
        {
            PropertiesClass.driver.Quit();
        }
    }
}