using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;

namespace PDV_Quality
{
    public class aberturaFechamentoCaixa
    {
        private readonly Tests aberturafechamentocaixa = new Tests();

        public static void AbrirCaixaFundoNegativo()
        {

        }
        public static void AbrirCaixaSemFundos()
        {
            Thread.Sleep(10000);
            Tests.Driver.FindElement(By.Name("CAIXA")).Click();
            Tests.Driver.FindElement(By.Name("ABERTURA / FECHAMENTO CAIXA")).Click();
            Tests.Driver.FindElement(By.Id("btnOK")).Click();
        }
        public static void AbrirCaixaFundoPositivo()
        {
            Thread.Sleep(10000);
            Tests.Driver.FindElement(By.Name("CAIXA")).Click();
            Tests.Driver.FindElement(By.Name("ABERTURA / FECHAMENTO CAIXA")).Click();
            Tests.Driver.FindElement(By.Id("txtFundo")).SendKeys("20");
            Tests.Driver.FindElement(By.Id("btnOK")).Click();
        }
        public static void FecharCaixaCancelar()
        {
            Thread.Sleep(10000);
            Tests.Driver.FindElement(By.Name("CAIXA")).Click();
            Tests.Driver.FindElement(By.Name("ABERTURA / FECHAMENTO CAIXA")).Click();
            Tests.Driver.FindElement(By.Id("btnCANCELAR")).Click();
        }
        public static void FecharCaixaManual()
        {
            Thread.Sleep(10000);
            Tests.Driver.FindElement(By.Name("CAIXA")).Click();
            Tests.Driver.FindElement(By.Name("ABERTURA / FECHAMENTO CAIXA")).Click();
            Tests.Driver.FindElement(By.Id("btnOK")).Click();
            Tests.Driver.FindElement(By.Id("btnOK")).Click();
        }
    }
}
