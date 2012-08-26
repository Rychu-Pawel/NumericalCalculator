﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Globalization;
using NumericalCalculator.Translations;
using NumericalCalculator.Logic;

namespace NumericalCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowLogic logic = new MainWindowLogic();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void miClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void miMean_Click(object sender, RoutedEventArgs e)
        {
            MeanWindow mw = new MeanWindow();
            mw.Show();
        }

        private void miGraph_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miLanguage_Click(object sender, RoutedEventArgs e)
        {
            Translation.ToggleLanguage();
        }

        private void miClick_OpenWindow(object sender, RoutedEventArgs e)
        {
            MenuItem mi = sender as MenuItem;

            //Wybranie okna
            Window window = null;

            if (mi.Name == miLinearEquations.Name)
                window = new LinearEquationWindow();
            else if (mi.Name == miInterpolation.Name)
                window = new InterpolationWindow();
            else if (mi.Name == miProportion.Name)
                window = new ProportionWindow();
            else if (mi.Name == miMean.Name)
                window = new MeanWindow();
            else if (mi.Name == miAbout.Name)
                window = new AboutWindow();
            else if (mi.Name == miFunctions.Name)
                window = new FunctionsWindow();

            //Pokazanie okna
            if (window != null)
                window.Show();
        }
    }
}
