using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PageObjects
{
    class LoginClass
    {
        public LoginClass()
        {
            PageFactory.InitElements(PropertiesClass.driver, this);
        }




        [FindsBy(How = How.Id, Using = "txtUsername")]
        public IWebElement UsernameTxtBox { get; set; }

        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement PasswordTxtBox { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement LoginBtn { get; set; }

    }
}
   