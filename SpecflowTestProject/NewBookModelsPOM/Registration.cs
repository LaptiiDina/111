using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecflowTestProject.NewBookModelsPOM
{
    public class Registration
    {
        private readonly IWebDriver _driver;



        public Registration(IWebDriver driver)
        {
            _driver = driver;
        }

        private static readonly By FirstName = By.CssSelector("body > nb-app > nb-signup > common-react-bridge > div > div.PageLayout__content--2G3GY > div > section > section > div.SignupPageLayout__card--1FXcr > form > section > section > div > div.SignupFormLayout__right--zBcM3 > section > div > section > div:nth-child(1) > div:nth-child(1) > label > input");
        private static readonly By LastName = By.CssSelector("body > nb-app > nb-signup > common-react-bridge > div > div.PageLayout__content--2G3GY > div > section > section > div.SignupPageLayout__card--1FXcr > form > section > section > div > div.SignupFormLayout__right--zBcM3 > section > div > section > div:nth-child(1) > div:nth-child(2) > label > input");
        private static readonly By Email = By.CssSelector("body > nb-app > nb-signup > common-react-bridge > div > div.PageLayout__content--2G3GY > div > section > section > div.SignupPageLayout__card--1FXcr > form > section > section > div > div.SignupFormLayout__right--zBcM3 > section > div > section > div:nth-child(2) > div > label > input");
        private static readonly By Password = By.CssSelector("body > nb-app > nb-signup > common-react-bridge > div > div.PageLayout__content--2G3GY > div > section > section > div.SignupPageLayout__card--1FXcr > form > section > section > div > div.SignupFormLayout__right--zBcM3 > section > div > section > div:nth-child(3) > div:nth-child(1) > label > input");
        private static readonly By ConfirmPassword = By.CssSelector("body > nb-app > nb-signup > common-react-bridge > div > div.PageLayout__content--2G3GY > div > section > section > div.SignupPageLayout__card--1FXcr > form > section > section > div > div.SignupFormLayout__right--zBcM3 > section > div > section > div:nth-child(3) > div:nth-child(2) > label > input");
        private static readonly By Phone = By.CssSelector("input[placeholder='555.867.5309']");
        private static readonly By Button = By.CssSelector("body > nb-app > nb-signup > common-react-bridge > div > div.PageLayout__content--2G3GY > div > section > section > div.SignupPageLayout__card--1FXcr > form > section > section > div > div.SignupFormLayout__right--zBcM3 > section > div > section > button");

        public void FirstNameField(string name)

        {
            _driver.FindElement(FirstName).SendKeys(name);
        }

        public void LastNameField(string SecondName)
        {
            _driver.FindElement(LastName).SendKeys(SecondName);
        }
        public void EmailField(string E)
        {
            _driver.FindElement(Email).SendKeys(E);
        }
        public void FillPasswordField(string p)
        {
            _driver.FindElement(Password).SendKeys(p);
        }
        public void FillConfirmPassword(string cp)
        {
            _driver.FindElement(ConfirmPassword).SendKeys(cp);
        }
        public void FillPhone(string mobile)
        {
           
            _driver.FindElement(Phone).SendKeys(mobile);
        }

        public void ClickLogInBtn()
        {
            
            _driver.FindElement(Button).Click();
        }

        public void RegistrPageIsOpened()
        {
            _driver.Navigate().GoToUrl("https://newbookmodels.com/join");
        }
    }
}
    

