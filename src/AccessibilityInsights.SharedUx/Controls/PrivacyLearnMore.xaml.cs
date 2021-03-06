﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System.Windows.Controls;
using System.Windows.Navigation;
using System;
using System.Diagnostics;
using AccessibilityInsights.SharedUx.Dialogs;
using AccessibilityInsights.SharedUx.Telemetry;
using System.Globalization;
using AccessibilityInsights.CommonUxComponents.Dialogs;

namespace AccessibilityInsights.SharedUx.Controls
{
    /// <summary>
    /// Interaction logic for PrivacyLearnMore.xaml
    /// </summary>
    public partial class PrivacyLearnMore : TextBlock
    {
        public PrivacyLearnMore()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Go to link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            }
            catch (Exception ex)
            {
                ex.ReportException();
                MessageDialog.Show(string.Format(CultureInfo.CurrentCulture, Properties.Resources.InvalidLink, e.Uri.AbsoluteUri));
            }
        }
    }
}
