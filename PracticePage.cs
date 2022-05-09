using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Net;
using System.Collections.ObjectModel;
using DemoQASite;

namespace PracticePage_site
{
    class PracticePage : Selenium_Base
    {
        public void GoToPracticePage()
        {
            open("https://courses.letskodeit.com/practice");
            wait(2000);
        }
        public void RadioButton()
        {
            click(FindXPath("//input[@id='benzradio']"));
            wait(2000);
        }
        public void SelectClass()
        {
            click(FindXPath("//select[@id='carselect']"));
            wait(2000);
            click(FindXPath("//option[text()='Benz']"));
            wait(2000);
        }
        public void MultipleSelectClass()
        {
            getAction().KeyDown(Keys.LeftControl)
                .MoveToElement(FindXPath("//option[text()='Apple']"))
                .Click()
                .MoveToElement(FindXPath("//option[text()='Orange']"))
                .Click()
                .Release()
                .Build()
                .Perform();

            wait(1000);
        }
        public void CheckBox()
        {
            click(FindXPath("//input[@id='bmwcheck']"));
            wait(2000);
            click(FindXPath("//input[@id='benzcheck']"));
            wait(2000);
        }
        public void SwitchWindow()
        {
            click(FindXPath("//button[@id='openwindow']"));
            wait(2000);
            switchToWindow(1);
            wait(2000);
            scrollPage(0, 800);
            wait(5000);
            close();
            switchToWindow(0);
            wait(1000);
        }
        public void SwitchTab()
        {
            click(FindXPath("//a[@id='opentab']"));
            wait(2000);
            switchToWindow(1);
            wait(2000);
            scrollPage(0, 1000);
            wait(5000);
            close();
            switchToWindow(0);
            wait(1000);
        }
        public void SwitchAlert()
        {
            sendKeys(FindXPath("//input[@name='enter-name']"), "Laxmi");
            wait(1000);
            sendKeys(FindXPath("//input[@name='enter-name']"), "Laxmi");
            wait(1000);
            click(FindXPath("//input[@id='alertbtn']"));
            wait(2000);
            acceptAlert();
            sendKeys(FindXPath("//input[@name='enter-name']"), "Laxmi");
            wait(1000);
            click(FindXPath("//input[@id='confirmbtn']"));
            wait(2000);
            rejectAlert();
        }
        public void EnableDisable()
        {
            click(FindXPath("//input[@id='disabled-button']"));
            wait(2000);
            Disable();
            wait(1000);
            click(FindXPath("//input[@id='enabled-button']"));
            wait(2000);
            sendKeys(FindXPath("//input[@id='enabled-example-input']"), "Laxmi");
            wait(1000);
        }
        public void Disable()
        {
            try
            {
                sendKeys(FindXPath("//input[@id='enabled-example-input']"), "l");
                wait(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Disable to click");
            }
        }
        public void HideShow()
        {
            sendKeys(FindXPath("//input[@id='displayed-text']"), "Laxmi");
            wait(2000);
            click(FindXPath("//input[@id='hide-textbox']"));
            wait(2000);
            click(FindXPath("//input[@id='show-textbox']"));
            wait(2000);
        }
        public void MouseHover()
        {
            scrollPage(0, 300);
            wait(1000);
            hoverOnto(FindXPath("//button[@id='mousehover']"));
            wait(2000);
            click(FindXPath("//a[text()='Top']"));
            wait(2000);
            scrollPage(0, 400);
            wait(1000);
            hoverOnto(FindXPath("//button[@id='mousehover']"));
            wait(2000);
            click(FindXPath("//a[text()='Reload']"));
            wait(2000);
        }
        public void iframe()
        {
            scrollPage(0, 700);
            wait(1000);
            switchToanotherFrame("//iframe[@id='courses-iframe']");
            wait(1000);
            scrollPage(0, 1500);
            wait(1000);
            scrollPage(0, -1000);
            wait(3000);
            close();
        }
    }
}
