using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PageObjects
{
    class AddCandtesClass
    {
        public AddCandtesClass()
        {
            PageFactory.InitElements(PropertiesClass.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='addCandidate_firstName']")]
        public IWebElement FnameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='addCandidate_middleName']")]
        public IWebElement MnameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='addCandidate_lastName']")]
        public IWebElement LnameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='addCandidate_email']")]
        public IWebElement MailTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='addCandidate_contactNo']")]
        public IWebElement ContactTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='addCandidate_appliedDate']")]
        public IWebElement DateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Required']")]
        public IWebElement RequiredMsg { get; set; }

        [FindsBy(How = How.Id, Using = "btnBack")]
        public IWebElement BackBtn { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement SorEBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@data-handler='selectMonth']")]
        public IWebElement slctMonth { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='frmAddCandidate']//img[1]")]
        public IWebElement ClndrImg { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@data-handler='selectYear']")]
        public IWebElement slctYear { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='ui-datepicker-calendar']/tbody[1]/tr[2]/td[3]/a[1]")]
        public IWebElement slctDate8 { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='ui-datepicker-calendar']/tbody[1]/tr[4]/td[5]/a[1]")]
        public IWebElement slctDate24 { get; set; }
    }
}
