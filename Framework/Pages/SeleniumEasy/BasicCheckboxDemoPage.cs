﻿namespace Framework.Pages.SeleniumEasy
{
    public class BasicCheckboxDemoPage
    {
        public static void clickSingleCheckbox()
        {
            string locator = "//*[@id='isAgeSelected']";
            Common.clickElement(locator);
        }

        public static string readMessage()
        {
            string locator = "//*[@id='txtAge']";
            return Common.getElementText(locator);
        }
    }
}