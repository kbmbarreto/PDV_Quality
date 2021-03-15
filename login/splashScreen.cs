using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;

namespace PDV_Quality
{
    public class splashScreen
    {
        private readonly Tests splashscreen = new Tests();

        public static void SplashScreen()
        {
            Thread.Sleep(10000);
            Tests.Driver.FindElement(By.Id("pcbBtnOk")).Click();
        }
    }
}
