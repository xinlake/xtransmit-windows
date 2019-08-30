﻿using System.Windows;
using XTransmit.Model;
using XTransmit.ViewModel;

namespace XTransmit.View
{
    public partial class WindowUserAgent : Window
    {
        /**
         * Updated: 2019-08-02
         */
        public WindowUserAgent()
        {
            InitializeComponent();

            Preference preference = App.GlobalPreference;
            Left = preference.WindowUserAgent.X;
            Top = preference.WindowUserAgent.Y;
            Width = preference.WindowUserAgent.W;
            Height = preference.WindowUserAgent.H;

            DataContext = new UserAgentVModel();
            Closing += WindowUserAgent_Closing;
        }

        private void WindowUserAgent_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ((UserAgentVModel)DataContext).OnWindowClosing();

            // Save window placement
            Preference preference = App.GlobalPreference;
            preference.WindowUserAgent.X = Left;
            preference.WindowUserAgent.Y = Top;
            preference.WindowUserAgent.W = Width;
            preference.WindowUserAgent.H = Height;
        }
    }
}