﻿namespace Apex_Launcher {
    partial class Launcher {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.LaunchButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.DiscordLogo = new System.Windows.Forms.PictureBox();
            this.TabBox = new System.Windows.Forms.TabControl();
            this.UpdatesPage = new System.Windows.Forms.TabPage();
            this.NoConnectionLabel = new System.Windows.Forms.Label();
            this.TumblrBrowser = new System.Windows.Forms.WebBrowser();
            this.CommunityPage = new System.Windows.Forms.TabPage();
            this.RedditBrowser = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveMgmtButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LauncherVersionLabel = new System.Windows.Forms.Label();
            this.GameVersionLabel = new System.Windows.Forms.Label();
            this.LauncherTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DiscordLogo)).BeginInit();
            this.TabBox.SuspendLayout();
            this.UpdatesPage.SuspendLayout();
            this.CommunityPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LaunchButton
            // 
            this.LaunchButton.Enabled = false;
            this.LaunchButton.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.Location = new System.Drawing.Point(1039, 514);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(295, 122);
            this.LaunchButton.TabIndex = 0;
            this.LaunchButton.Text = "Launch Game";
            this.LauncherTooltip.SetToolTip(this.LaunchButton, "Launch the game!");
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(525, 514);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(253, 122);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.LauncherTooltip.SetToolTip(this.SettingsButton, "Change launcher settings here.");
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // DiscordLogo
            // 
            this.DiscordLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DiscordLogo.BackgroundImage")));
            this.DiscordLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscordLogo.Location = new System.Drawing.Point(13, 514);
            this.DiscordLogo.Name = "DiscordLogo";
            this.DiscordLogo.Size = new System.Drawing.Size(250, 122);
            this.DiscordLogo.TabIndex = 3;
            this.DiscordLogo.TabStop = false;
            this.LauncherTooltip.SetToolTip(this.DiscordLogo, "Join our Discord server to chat with the community!");
            this.DiscordLogo.Click += new System.EventHandler(this.DiscordLogo_Click);
            // 
            // TabBox
            // 
            this.TabBox.Controls.Add(this.UpdatesPage);
            this.TabBox.Controls.Add(this.CommunityPage);
            this.TabBox.Location = new System.Drawing.Point(13, 13);
            this.TabBox.Name = "TabBox";
            this.TabBox.SelectedIndex = 0;
            this.TabBox.Size = new System.Drawing.Size(1321, 486);
            this.TabBox.TabIndex = 4;
            // 
            // UpdatesPage
            // 
            this.UpdatesPage.Controls.Add(this.NoConnectionLabel);
            this.UpdatesPage.Controls.Add(this.TumblrBrowser);
            this.UpdatesPage.Location = new System.Drawing.Point(4, 22);
            this.UpdatesPage.Name = "UpdatesPage";
            this.UpdatesPage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdatesPage.Size = new System.Drawing.Size(1313, 460);
            this.UpdatesPage.TabIndex = 0;
            this.UpdatesPage.Text = "Game Updates";
            this.UpdatesPage.UseVisualStyleBackColor = true;
            // 
            // NoConnectionLabel
            // 
            this.NoConnectionLabel.AutoSize = true;
            this.NoConnectionLabel.Location = new System.Drawing.Point(16, 19);
            this.NoConnectionLabel.Name = "NoConnectionLabel";
            this.NoConnectionLabel.Size = new System.Drawing.Size(284, 13);
            this.NoConnectionLabel.TabIndex = 1;
            this.NoConnectionLabel.Text = "Could not connect to the internet. Can\'t check for updates.";
            // 
            // TumblrBrowser
            // 
            this.TumblrBrowser.AllowWebBrowserDrop = false;
            this.TumblrBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TumblrBrowser.Location = new System.Drawing.Point(3, 3);
            this.TumblrBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TumblrBrowser.Name = "TumblrBrowser";
            this.TumblrBrowser.ScriptErrorsSuppressed = true;
            this.TumblrBrowser.Size = new System.Drawing.Size(1307, 454);
            this.TumblrBrowser.TabIndex = 0;
            this.TumblrBrowser.Url = new System.Uri("https://pokemonapex.tumblr.com", System.UriKind.Absolute);
            this.TumblrBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.BrowserLoaded);
            this.TumblrBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.BrowserNavigation);
            // 
            // CommunityPage
            // 
            this.CommunityPage.Controls.Add(this.RedditBrowser);
            this.CommunityPage.Location = new System.Drawing.Point(4, 22);
            this.CommunityPage.Name = "CommunityPage";
            this.CommunityPage.Padding = new System.Windows.Forms.Padding(3);
            this.CommunityPage.Size = new System.Drawing.Size(1313, 460);
            this.CommunityPage.TabIndex = 1;
            this.CommunityPage.Text = "Community Posts";
            this.CommunityPage.UseVisualStyleBackColor = true;
            // 
            // RedditBrowser
            // 
            this.RedditBrowser.AllowWebBrowserDrop = false;
            this.RedditBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedditBrowser.Location = new System.Drawing.Point(3, 3);
            this.RedditBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.RedditBrowser.Name = "RedditBrowser";
            this.RedditBrowser.ScriptErrorsSuppressed = true;
            this.RedditBrowser.Size = new System.Drawing.Size(1307, 454);
            this.RedditBrowser.TabIndex = 0;
            this.RedditBrowser.Url = new System.Uri("https://reddit.com/r/PokemonApex", System.UriKind.Absolute);
            this.RedditBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.BrowserNavigation);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 122);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.LauncherTooltip.SetToolTip(this.pictureBox1, "https://reddit.com/r/PokemonApex");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SaveMgmtButton
            // 
            this.SaveMgmtButton.Enabled = false;
            this.SaveMgmtButton.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveMgmtButton.Location = new System.Drawing.Point(783, 514);
            this.SaveMgmtButton.Name = "SaveMgmtButton";
            this.SaveMgmtButton.Size = new System.Drawing.Size(250, 122);
            this.SaveMgmtButton.TabIndex = 7;
            this.SaveMgmtButton.Text = "Manage Saves\r\n(Coming soon)";
            this.LauncherTooltip.SetToolTip(this.SaveMgmtButton, "Patience, Iago.");
            this.SaveMgmtButton.UseVisualStyleBackColor = true;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(13, 641);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(174, 19);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Ready to Launch";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LauncherVersionLabel
            // 
            this.LauncherVersionLabel.AutoSize = true;
            this.LauncherVersionLabel.ForeColor = System.Drawing.Color.White;
            this.LauncherVersionLabel.Location = new System.Drawing.Point(1249, 502);
            this.LauncherVersionLabel.Name = "LauncherVersionLabel";
            this.LauncherVersionLabel.Size = new System.Drawing.Size(85, 13);
            this.LauncherVersionLabel.TabIndex = 9;
            this.LauncherVersionLabel.Text = "Launcher v1.1.0";
            this.LauncherTooltip.SetToolTip(this.LauncherVersionLabel, "Your current launcher version.");
            // 
            // GameVersionLabel
            // 
            this.GameVersionLabel.AutoSize = true;
            this.GameVersionLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersionLabel.ForeColor = System.Drawing.Color.White;
            this.GameVersionLabel.Location = new System.Drawing.Point(1035, 641);
            this.GameVersionLabel.Name = "GameVersionLabel";
            this.GameVersionLabel.Size = new System.Drawing.Size(185, 19);
            this.GameVersionLabel.TabIndex = 10;
            this.GameVersionLabel.Text = "Build: ALPHA 3.1";
            this.GameVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LauncherTooltip.SetToolTip(this.GameVersionLabel, "Your currently installed game version. Updated automatically.");
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1346, 669);
            this.Controls.Add(this.GameVersionLabel);
            this.Controls.Add(this.LauncherVersionLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SaveMgmtButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TabBox);
            this.Controls.Add(this.DiscordLogo);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.LaunchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apex Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launcher_FormClosing);
            this.Shown += new System.EventHandler(this.Launcher_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DiscordLogo)).EndInit();
            this.TabBox.ResumeLayout(false);
            this.UpdatesPage.ResumeLayout(false);
            this.UpdatesPage.PerformLayout();
            this.CommunityPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.PictureBox DiscordLogo;
        private System.Windows.Forms.TabControl TabBox;
        private System.Windows.Forms.TabPage UpdatesPage;
        private System.Windows.Forms.TabPage CommunityPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SaveMgmtButton;
        private System.Windows.Forms.WebBrowser TumblrBrowser;
        private System.Windows.Forms.WebBrowser RedditBrowser;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label LauncherVersionLabel;
        private System.Windows.Forms.Label NoConnectionLabel;
        public System.Windows.Forms.Label GameVersionLabel;
        private System.Windows.Forms.ToolTip LauncherTooltip;
    }
}

