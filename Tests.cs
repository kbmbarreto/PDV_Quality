using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing.Imaging;

namespace PDV_Quality
{
    public class Tests
    {
        public static RemoteWebDriver Driver { get; set; }

        [SetUp]
        [Obsolete]
        public void Setup()
        {
            var dc = new DesiredCapabilities();
            dc.SetCapability("app", @"C:\PDV\PDV.UI.exe");
            Driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
        }

        [Test]
        [Order(0)]
        public void TestSplachScreen()
        {
            splashScreen.SplashScreen();
        }
        
        [Test]
        [Order(1)]
        public void TestLoginValido()
        {
            login.LoginValido();
        }
        
        [Test]
        [Order(2)]
        public void TestAbrirCaixaSemFudos()
        {
            aberturaFechamentoCaixa.AbrirCaixaSemFundos();
        }

        [Test]
        [Order(3)]
        public void TestFecharCaixaCancelar()
        {
            aberturaFechamentoCaixa.FecharCaixaCancelar();
        }

        [Test]
        [Order(4)]
        public void TestFecharCaixaManual()
        {
            aberturaFechamentoCaixa.FecharCaixaManual();
        }

        [Test]
        [Order(5)]
        public void TestAbrirCaixaPositivo()
        {
            aberturaFechamentoCaixa.AbrirCaixaFundoPositivo();
        }

        [Test]
        [Order(6)]
        public void TestMobile()
        {
            mobileConect.MobileConect();
        }
    }
}