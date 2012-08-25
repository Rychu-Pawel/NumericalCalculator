﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Threading;
using System.Globalization;
using Settings = NumericalCalculator.Properties.Settings;

namespace NumericalCalculator.Translations
{
    public class Translation
    {
        private static ObjectDataProvider languageResource;

        public Language GetResourceInstance()
        {
            return new Language();
        }

        public static void ToggleLanguage()
        {
            if (Settings.Default.Culture == "pl-PL")
                SetLanguage("en-GB");
            else
                SetLanguage("pl-PL");
        }

        public static void SetLanguage(string culture)
        {
            //Ustawienie języka
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            Language.Culture = new CultureInfo(culture);

            //Ustawienie settingsów
            Settings.Default.Culture = culture;

            if (culture == "pl-PL")
            {
                Settings.Default.chkMiPolish_Checked = true;
                Settings.Default.chkMiEnglish_Checked = false;
            }
            else
            {
                Settings.Default.chkMiPolish_Checked = false;
                Settings.Default.chkMiEnglish_Checked = true;
            }

            //Zapis settingsów
            Settings.Default.Save();

            //Odświeżenie gui
            RefreshGUI();
        }

        public static void RefreshGUI()
        {
            if (languageResource == null)
                languageResource = (ObjectDataProvider)App.Current.FindResource("Language");

            languageResource.Refresh();
        }

        public static string DefaultCulture()
        {
            if (Thread.CurrentThread.CurrentCulture.Name == "pl-PL")
                return "pl-PL";
            else
                return "en-GB";
        }
    }
}
