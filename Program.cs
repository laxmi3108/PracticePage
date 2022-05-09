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
    internal class Program : Selenium_Base
    {
        static void Main(string[] args)
        {
            PracticePage practicePage = new PracticePage();

            practicePage.GoToPracticePage();
            practicePage.RadioButton();
            practicePage.SelectClass();
            practicePage.MultipleSelectClass();
            practicePage.CheckBox();
            practicePage.SwitchWindow();
            practicePage.SwitchTab();
            practicePage.SwitchAlert();
            practicePage.EnableDisable();
            practicePage.HideShow();
            practicePage.MouseHover();
            practicePage.iframe();
        }
    }
}
