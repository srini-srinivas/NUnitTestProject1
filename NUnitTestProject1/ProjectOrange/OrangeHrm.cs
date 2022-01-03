using NUnit.Framework;
using NUnitTestProject1.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitTestProject1.ProjectOrange
{
    public static class OrangeHrm
    {
        static LoginClass Login = new LoginClass();

        public static void LoginMthd(string Username, string Password)
        {
            try
            {
                Login.UsernameTxtBox.SendKeys(Username);
                Thread.Sleep(2000);
                Login.PasswordTxtBox.SendKeys(Password);
                PropertiesClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                Login.LoginBtn.Click();

                Console.WriteLine("Successfully Logged in");
            }
            catch(Exception e)
            {
                Console.WriteLine("OrangeHrm failed");
            }
            
        }

        static RecruitmentClass Recruitment = new RecruitmentClass();
        public static void RecMthd()
        {
            try
            {
                Recruitment.RecrmntBtn.Click();
                Thread.Sleep(1000);
                Recruitment.CandteBtn.Click();
                Console.WriteLine("Going to add the candidates in this page.");
                Recruitment.AddBtn.Click();
                Thread.Sleep(2000);
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong");
            }          
        }

        static AddCandtesClass AddCandidate = new AddCandtesClass();
        private static string firstName, lastName, middleName, eMail, contactNum;
        public static void AddMthd()
        {
            try
            {
                Random rnd = new Random();
                for (int j = 0; j < 1; j++)
                {
                    int num = rnd.Next(20);
                    Console.WriteLine("Unique number for giving inputs : " + num);
                    firstName = "fName";
                    lastName = "lName" + num;
                    middleName = "mName";
                    eMail = "fname@yahoo.com";
                    contactNum = "91+ (8345678909)";
                    AddCandidate.FnameTxt.SendKeys(firstName);
                    Thread.Sleep(2000);
                }

                AddCandidate.SorEBtn.Click();

                Assert.That(PropertiesClass.driver.PageSource.Contains("Required"), Is.EqualTo(true), "Fill the required details");

                Console.WriteLine("Fill the required details.");

                AddCandidate.MnameTxt.SendKeys(middleName);
                Thread.Sleep(2000);
                AddCandidate.LnameTxt.SendKeys(lastName);
                Thread.Sleep(2000);
                AddCandidate.SorEBtn.Click();

                Assert.That(PropertiesClass.driver.PageSource.Contains("Required"), Is.EqualTo(true), "No warning occured.");

                Console.WriteLine("Fill the required details .");

                AddCandidate.MailTxt.SendKeys("entermail");
                Thread.Sleep(2000);
                Assert.That(PropertiesClass.driver.PageSource.Contains("Expected format: admin@example.com"), Is.EqualTo(true), "No warning occured.");

                Console.WriteLine("Give the MailId in right format which occurs below.");

                AddCandidate.MailTxt.Clear();
                AddCandidate.MailTxt.SendKeys(eMail);
                Thread.Sleep(2000);
                Console.WriteLine("Suuccessfully added required details");

                AddCandidate.ContactTxt.SendKeys("ahsjdh");
                Thread.Sleep(2000);
                Assert.That(PropertiesClass.driver.PageSource.Contains("Allows numbers and only + - / ( )"), Is.EqualTo(true), "No warning occured.");

                Console.WriteLine("Give the Contact number in right format which occurs below.");

                AddCandidate.ContactTxt.Clear();
                Thread.Sleep(2000);
                AddCandidate.ContactTxt.SendKeys(contactNum);
                Console.WriteLine("Added contact number field");

                AddCandidate.DateTxt.Clear();
                AddCandidate.DateTxt.SendKeys("23112023");
                Thread.Sleep(2000);
                //Console.WriteLine("Check");

                Assert.That(PropertiesClass.driver.PageSource.Contains("Should be a valid date in yyyy-mm-dd format"), Is.EqualTo(true), "No warning occured.");

                Console.WriteLine("Give the Date in right format which occurs below.");
                AddCandidate.DateTxt.Clear();
                //AddCandidate.ClndrImg.Click();
                Thread.Sleep(2000);

                SelectElement month = new SelectElement(AddCandidate.slctMonth);
                month.SelectByIndex(4);
                Thread.Sleep(2000);

                SelectElement year = new SelectElement(AddCandidate.slctYear);
                year.SelectByValue("2020");
                Thread.Sleep(2000);

                AddCandidate.slctDate24.Click();
                Thread.Sleep(2000);

                Console.WriteLine("Date selected properly");


                AddCandidate.SorEBtn.Click();
                Thread.Sleep(2000);
                AddCandidate.BackBtn.Click();

                Console.WriteLine("Successfully added " + firstName + " " + middleName + " " + lastName + " candidate details");
            }

            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        public static void EditMthd()
        {
            try
            {
                Console.WriteLine("To edit the candidate name");
                //IWebElement Name = PropertiesClass.driver.FindElement(By.XPath("//a[contains(text(),'" + lastName + "')]"));
                IWebElement Name = PropertiesClass.driver.FindElement(By.XPath("//a[text()='"+firstName+ " " +middleName+ " " + lastName + "']"));
                Name.Click();
                Thread.Sleep(2000);
                AddCandidate.SorEBtn.Click();
                Thread.Sleep(2000);
                AddCandidate.MnameTxt.Clear();
                Thread.Sleep(2000);
                AddCandidate.SorEBtn.Click();

                Console.WriteLine("Edited middle name by clearing it.");

                AddCandidate.BackBtn.Click();

            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        public static void DeleteMthd()
        {
            try
            {
                IWebElement DelName = PropertiesClass.driver.FindElement(By.XPath("//a[text()='"+ firstName + "  " + lastName + "']/preceding::input[@type='checkbox'][1]"));
                DelName.Click();
                Thread.Sleep(2000);

                Recruitment.DeleteBtn.Click();
                Thread.Sleep(2000);
                Recruitment.OkDelete.Click();

                Console.WriteLine("Successfully deleted candidate name");

                Recruitment.WlcmIcon.Click();
                Recruitment.Logout.Click();

                Console.WriteLine("Logout done");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
        }




    }
}
