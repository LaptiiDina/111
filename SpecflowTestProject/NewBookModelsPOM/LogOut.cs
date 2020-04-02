using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTestProject.NewBookModelsPOM
{
    public class LogOut
    {

        private readonly IWebDriver _driver;
        public LogOut(IWebDriver driver)

        {
            _driver = driver;
        }


        private static readonly By Button = By.CssSelector("body > nb-app > nb-signup-company > common-react-bridge > div > div.ScrollableHeader__container--X5p8i.PageLayout__header--p3oFm > header > div > div > div.HeaderLayout__contentStatic--3p_AB > a.MainHeader__staticItemAvatar--3LwWp.MainHeader__staticItem--2UY1x > div > div");
        private static readonly By Link = By.XPath("/html/body/nb-app/ng-component/nb-internal-layout/common-layout/section/div/ng-component/nb-account-info-edit/common-border/div[6]/div/nb-account-logout/div[2]/div/nb-link/div");
        private static readonly By PasswordField = By.CssSelector("input[type=password]");

        public void ButtonSettings()

        {
            _driver.FindElement(Button).Click();

        }
        public void ClickLink()

        {
            _driver.FindElement(Link).Click();

        }
        public bool IsFinishBtnDisplayed()
        {
            return _driver.FindElement(PasswordField).Displayed;
        }
    }
}
