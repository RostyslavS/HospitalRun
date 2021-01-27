﻿using HospitalRun.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HospitalRun
{
    class LoginInvalidTest
    {

        IWebDriver webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();

        [Test]
        public void LogInInvalid()
        {
            var loginPage = new LoginPageObject(webDriver);
            loginPage
                .LoginInvalid();
        }
        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }

    }
}
