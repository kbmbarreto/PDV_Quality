using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;

namespace PDV_Quality
{
    public class mobileConect
    {
        private readonly Tests mobileconect = new Tests();

        public static void MobileConect()
        {
            Thread.Sleep(10000);
            Tests.Driver.FindElement(By.Name("MOBILE CONNECT")).Click();
            funcoesManutencao.RelogarPDV();
        }
    }
}
