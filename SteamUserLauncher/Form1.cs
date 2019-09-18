using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace SteamUserLauncher
{
    public partial class SteamUserSwitcher : Form
    {
        String chosen_button = "Default";
        public SteamUserSwitcher()
        {
            InitializeComponent();
            
        }
        private void button_click(object sender, EventArgs e)
        {
            chosen_button = ((Button)sender).Text;
            foreach(Process proc in Process.GetProcessesByName("Steam"))
            {
                proc.Kill();
            }

            Microsoft.Win32.RegistryKey key;
            key = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam", true);
            key.SetValue("AutoLoginUser", ((Button)sender).Text, RegistryValueKind.String);
            key.SetValue("RememberPassword", 1, RegistryValueKind.DWord);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"steam://open/main";
            Process.Start(startInfo);
            this.WindowState = FormWindowState.Minimized;
        }


        private void Window_Shown(object sender, EventArgs e)
        {
            Hide();
            tray_notify_icon.Visible = true;
        }

        private void trayIconDoubleClick(object sender, MouseEventArgs e)
        {
            Show();//shows the program on taskbar
            this.WindowState = FormWindowState.Normal;//undoes the minimized state of the form
            tray_notify_icon.Visible = false;//hides tray icon again
        }

        private void Window_Resize(object sender, EventArgs e)
        {

        }
    }
}
