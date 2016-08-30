using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

//添加引用-在程序集中添加System.Drawing
using System.Drawing;
using System.Drawing.Imaging;

using System.Collections.ObjectModel;
using SeleniumHelper;


namespace UnitTestProject1
{
    [TestClass]
    public class LoginPage : ExtJSPage
    {
       
        public LoginPage(string url, IWebDriver webDriver) : base(url,webDriver)
        {
       
        }
          private TextBox txtUserName;
          private TextBox txtPassword;
          private Button btnLogin;
         [TestMethod]
        protected void init(){
          txtUserName =new TextBox("userName", webDriver);
          txtPassword =new TextBox("password", webDriver);
          btnLogin =new Button("登录", webDriver);
 
 
          Window win =new Window("登陆", webDriver);
          win.addChild(txtUserName);
          win.addChild(txtPassword);
          win.addChild(btnLogin);
 
 
          this.addChild(win);
         }

        [TestMethod]
         public void login(String userName, String password){
              txtUserName.setValue(userName);
              txtPassword.setValue(password);
              btnLogin.click();
         }
    }
}
