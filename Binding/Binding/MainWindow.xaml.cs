﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingTarget
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmd_SetSmall(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 2;
        }

        private void cmd_SetNormal(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = this.FontSize;
        }

        private void cmd_SetLarge(object sender, RoutedEventArgs e)
        {
            lblSampleText.FontSize = 30;
        }

        private void cmd_GetBoundObject(object sender, RoutedEventArgs e)
        {
            Binding binding = BindingOperations.GetBinding(txtBound, TextBox.TextProperty);
            MessageBox.Show("Bound " + binding.Path.Path + " to source element " + binding.ElementName);

            BindingExpression expression = BindingOperations.GetBindingExpression(txtBound, TextBox.TextProperty);
            MessageBox.Show("Bound " + expression.ResolvedSourcePropertyName + " with data " + ((TextBlock)expression.ResolvedSource).FontSize);

        }
    }
}
