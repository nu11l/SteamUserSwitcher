namespace SteamUserLauncher
{
    partial class SteamUserSwitcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteamUserSwitcher));
            this.tray_notify_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.account_2 = new WindowsFormsApplication1.RoundButton();
            this.account_1 = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // tray_notify_icon
            // 
            this.tray_notify_icon.Icon = ((System.Drawing.Icon)(resources.GetObject("tray_notify_icon.Icon")));
            this.tray_notify_icon.Text = "Steam User";
            this.tray_notify_icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIconDoubleClick);
            // 
            // account_2
            // 
            this.account_2.Endcolor = System.Drawing.Color.Black;
            this.account_2.Location = new System.Drawing.Point(99, 145);
            this.account_2.Name = "account_2";
            this.account_2.Size = new System.Drawing.Size(101, 104);
            this.account_2.Startcolor = System.Drawing.Color.White;
            this.account_2.TabIndex = 7;
            this.account_2.Text = "user_2";
            this.account_2.Textcolor = System.Drawing.Color.Black;
            this.account_2.UseVisualStyleBackColor = true;
            this.account_2.Click += new System.EventHandler(this.button_click);
            // 
            // account_1
            // 
            this.account_1.Endcolor = System.Drawing.Color.Black;
            this.account_1.Location = new System.Drawing.Point(99, 12);
            this.account_1.Name = "account_1";
            this.account_1.Size = new System.Drawing.Size(101, 104);
            this.account_1.Startcolor = System.Drawing.Color.White;
            this.account_1.TabIndex = 6;
            this.account_1.Text = "user_1";
            this.account_1.Textcolor = System.Drawing.Color.Black;
            this.account_1.UseVisualStyleBackColor = true;
            this.account_1.Click += new System.EventHandler(this.button_click);
            // 
            // SteamUserSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.account_2);
            this.Controls.Add(this.account_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SteamUserSwitcher";
            this.Text = "Steam User Switcher";
            this.Shown += new System.EventHandler(this.Window_Shown);
            this.Resize += new System.EventHandler(this.Window_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApplication1.RoundButton account_1;
        private WindowsFormsApplication1.RoundButton account_2;
        private System.Windows.Forms.NotifyIcon tray_notify_icon;
    }
}

