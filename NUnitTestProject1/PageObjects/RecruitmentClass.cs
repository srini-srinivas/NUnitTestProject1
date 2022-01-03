using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PageObjects
{
    class RecruitmentClass
    {
        public RecruitmentClass()
        {
            PageFactory.InitElements(PropertiesClass.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//b[text()='Recruitment']")]
        public IWebElement RecrmntBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Candidates']")]
        public IWebElement CandteBtn { get; set; }

        [FindsBy(How = How.Id, Using = "btnAdd")]
        public IWebElement AddBtn { get; set; }

        [FindsBy(How = How.Id, Using = "btnDelete")]
        public IWebElement DeleteBtn { get; set; }

        [FindsBy(How = How.Id, Using = "dialogDeleteBtn")]
        public IWebElement OkDelete { get; set; }

        [FindsBy(How = How.Id, Using = "btnSrch")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.Id, Using = "btnRst")]
        public IWebElement ResetBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='welcome']")]
        public IWebElement WlcmIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Logout']")]
        public IWebElement Logout { get; set; }
    }
}
