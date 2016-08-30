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
    public class Window : CompositeControl
    {
        private String title;
        public Window(String title,IWebDriver webDriver) :base(webDriver){       
            this.title = title;
        }
        

        public String getQuery(){
            return String.Format("Ext.ComponentQuery.query(\"window[title='{0}']\")[0]",title);
        }
    }
}
