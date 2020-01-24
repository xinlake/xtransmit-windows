﻿using System.Globalization;
using System.Windows;
using XTransmit.Model;
using XTransmit.ViewModel.Element;

namespace XTransmit.ViewModel
{
    /** 
     * TODO - Add custom options.
     */
    class SettingVModel : BaseViewModel
    {
        public int SSTimeouts
        {
            get => ConfigManager.Global.SSTimeout;
            set
            {
                ConfigManager.Global.SSTimeout = value;
                OnPropertyChanged(nameof(SSTimeouts));
            }
        }

        public int IPInfoConnTimeout
        {
            get => ConfigManager.Global.IPInfoConnTimeout;
            set
            {
                ConfigManager.Global.IPInfoConnTimeout = value;
                OnPropertyChanged(nameof(IPInfoConnTimeout));
            }
        }

        public int ResponseConnTimeout
        {
            get { return ConfigManager.Global.ResponseConnTimeout; }
            set
            {
                ConfigManager.Global.ResponseConnTimeout = value;
                OnPropertyChanged(nameof(ResponseConnTimeout));
            }
        }

        public int PingTimeout
        {
            get { return ConfigManager.Global.PingTimeout; }
            set
            {
                ConfigManager.Global.PingTimeout = value;
                OnPropertyChanged(nameof(PingTimeout));
            }
        }

        public bool IsReplaceOldServer
        {
            get { return ConfigManager.Global.IsReplaceOldServer; }
            set
            {
                ConfigManager.Global.IsReplaceOldServer = value;
                OnPropertyChanged(nameof(IsReplaceOldServer));
            }
        }

        public ItemView[] Status { get; }

        public SettingVModel()
        {
            Status = new ItemView[]
            {
                new ItemView
                {
                    Label = (string)Application.Current.FindResource("dialog_setting_status_proxy_port"),
                    Text=ConfigManager.Global.SystemProxyPort.ToString(CultureInfo.InvariantCulture),
                },

                new ItemView
                {
                    Label = (string)Application.Current.FindResource("dialog_setting_status_ss_port"),
                    Text = ConfigManager.Global.GlobalSocks5Port.ToString(CultureInfo.InvariantCulture),
                }
            };
        }
    }
}
