using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace PDV_Quality
{
    public class login
    {
        private readonly Tests loginvalidoinvalido = new Tests();
        
        public static void LoginValido()
        {
            Thread.Sleep(10000);
            Tests.Driver.FindElement(By.Id("txtUsuario")).SendKeys("user");
            Tests.Driver.FindElement(By.Id("txtSenha")).SendKeys("password");
            Tests.Driver.FindElement(By.Id("btnEntrar")).Click();
        }
    }
}
