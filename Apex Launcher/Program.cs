﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO.Compression;

namespace Apex_Launcher {
    static class Program {

        public static Launcher launcher;
        public static bool NetworkConnected;
        public static bool forceUpdate = false;
        public static bool Downloading = false;
        
        [STAThread]
        static void Main() {
            try {
                WebRequest wr = WebRequest.Create("https://raw.githubusercontent.com/griffenx/Apex-Launcher/master/Apex%20Launcher/VersionManifest.xml");
                wr.GetResponse();
                NetworkConnected = true;
            } catch (WebException) {
                NetworkConnected = false;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            launcher = new Launcher();
            Application.Run(launcher);
        }

        public static void initialize() {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\config.txt")) {
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Apex_Launcher.config.txt")) {
                    using (FileStream fileStream = new FileStream(Directory.GetCurrentDirectory() + "\\config.txt", FileMode.CreateNew)) {
                        for (int i = 0; i < stream.Length; i++) fileStream.WriteByte((byte)stream.ReadByte());
                    }
                }
            }

            //TODO: check for launcher update
            if (NetworkConnected) {
                try {
                    InstallLatestVersion();
                } catch (WebException) {
                    NetworkConnected = false;
                }
            }

            // Remove or add fonts
            /*foreach (string filepath in Directory.GetFiles(GetInstallPath() + "\\Versions\\" + GetCurrentVersion().ToString() + "\\Fonts")) {
                if (filepath.Contains(".ttf")) {

                    string filename = filepath.Split('\\')[filepath.Split('\\').Length - 1];
                    if (Convert.ToBoolean(GetParameter("disableGameFonts"))) {

                        if (File.Exists("C:\\Windows\\Fonts\\" + filename)) {
                            File.Delete("C:\\Windows\\Fonts\\" + filename);
                            
                        }
                    } else {
                        if (!File.Exists("C:\\Windows\\Fonts\\" + filename)) {
                            File.Copy(filepath, "C:\\Windows\\Fonts\\" + filename);
                        }
                    }
                }
            }*/

            
            
            return;
        }

        //public static void CheckForLauncherUpdate()

        public static string GetParameter(string parameter) {
            foreach (string line in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\config.txt")) {
                if (line.Length > 0 && !(new[] { '\n', ' ', '#' }.Contains(line[0])) && line.Contains('=')) {
                    if (line.Split('=')[0].ToLower().Equals(parameter.ToLower())) {
                        return line.Split('=')[1];
                    }
                }
            }
            return null;
        }

        public static void SetParameter(string parameter, string value) {
            if (GetParameter(parameter) == null) {
                File.AppendAllText(Directory.GetCurrentDirectory() + "\\config.txt", parameter + "=" + value + "\n");
            } else {
                string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\config.txt");
                int foundline = -1;
                foreach (string line in lines) {
                    if (line.Length > 0 && !(new[] { '\n', ' ', '#' }.Contains(line[0])) && line.Contains('=')) {
                        if (line.Split('=')[0].ToLower().Equals(parameter.ToLower())) {
                            foundline = Array.IndexOf(lines, line);
                            break;
                        }
                    }
                }
                if (foundline > -1) {
                    lines[foundline] = parameter + "=" + value;
                    File.WriteAllLines(Directory.GetCurrentDirectory() + "\\config.txt", lines);
                }
            }
        }

        public static Version GetCurrentVersion() {
            return Version.FromString(GetParameter("currentversion"));
        }

        public static bool InstallLatestVersion() {
            launcher.UpdateStatus("Checking for new versions...");

            Version mostRecent = GetMostRecentVersion();

            if (mostRecent != null && mostRecent.GreaterThan(GetCurrentVersion())) {
                DialogResult result = MessageBox.Show("New version found: " + mostRecent.Channel.ToString() + " " + mostRecent.Number + "\nDownload and install this update?", "Update Found", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {
                    DownloadVersion(mostRecent);
                    return true;
                } else return false;
            }

            launcher.UpdateStatus("No new version found.");
            return false;
        }

        public static Version GetMostRecentVersion() {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://raw.githubusercontent.com/griffenx/Apex-Launcher/master/Apex%20Launcher/VersionManifest.xml");

            Version mostRecent = GetCurrentVersion();
            foreach (XmlNode node in doc.GetElementsByTagName("version")) {
                Channel channel = Channel.NONE;
                double number = 0.0;
                string location = "";

                foreach (XmlNode prop in node.ChildNodes) {
                    switch (prop.Name.ToLower()) {
                        case "channel":
                            switch (prop.InnerText[0]) {
                                case 'a':
                                    channel = Channel.ALPHA;
                                    break;
                                case 'b':
                                    channel = Channel.BETA;
                                    break;
                                case 'r':
                                    channel = Channel.RELEASE;
                                    break;
                                default:
                                    channel = Channel.NONE;
                                    break;
                            }
                            break;
                        case "number":
                            try {
                                number = Convert.ToDouble(prop.InnerText);
                            } catch (FormatException) {
                                number = 0.0;
                            }
                            break;
                        case "location":
                            location = prop.InnerText;
                            break;
                    }
                }
                Version v = new Version(channel, number, location);
                if (mostRecent == null || v.GreaterThan(mostRecent) || v.Equals(mostRecent)) mostRecent = v;
            }

            return mostRecent;
        }

        public static void DownloadVersion(Version v) {
            DownloadForm dlf = new DownloadForm(v);
            dlf.Show();
            dlf.StartDownload();

            //wc.DownloadFile(v.Location, filename + ".zip");
        }

        public static string GetInstallPath() {
            string installpath = GetParameter("installpath");
            if (installpath.Length == 0) installpath = Directory.GetCurrentDirectory();
            return installpath;
        }

        public static bool HasWriteAccess(string folderPath) {
            try {
                System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                return true;
            } catch (UnauthorizedAccessException) {
                return false;
            }
        }

        public static string GetLauncherVersion() {
            string v = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            return v.Substring(0,v.Length - 2);
        }
    }
}
