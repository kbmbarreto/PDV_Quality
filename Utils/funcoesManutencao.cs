using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace PDV_Quality
{
    public class funcoesManutencao
    {
        private readonly Tests funcoesmanutencao = new Tests();

        public static void RelogarPDV()
        {
            Thread.Sleep(10000);
            Tests.Driver.FindElement(By.Id("btnDeslogar")).Click();
            splashScreen.SplashScreen();
            login.LoginValido();
        }

        public static void ScreenShot()
        {
            ITakesScreenshot screen = Tests.Driver as ITakesScreenshot;
            Screenshot scrnst = screen.GetScreenshot();
            string screenshot = "C:\\PDV_Quality\\screenshot\\FailedPage.Jpeg";
            scrnst.SaveAsFile(screenshot);
        }
    }
}
