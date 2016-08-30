using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SeleniumHelper
{
    public class ExtJSPage : CompositeControl
    {
        public ExtJSPage(string url,IWebDriver driver):base(driver){
            driver = new InternetExplorerDriver(@"E:\IEDriverServer_Win32_2.53.1\");
            driver.Navigate().GoToUrl(url);
        }
    }
}
