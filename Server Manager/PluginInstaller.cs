using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Manager
{
    public partial class PluginInstaller : Form
    {
        private Versions version = Versions.Version_null;
        public PluginInstaller(Versions version)
        {
            this.version = version;
            InitializeComponent();
        }

        private void PluginInstaller_Load(object sender, EventArgs e)
        {
            Databases.Plugin pluginmanager = new Databases.Plugin();
            foreach (var plugin in pluginmanager.GetPluginsByMinecraftVersion(version))
            {
                listBox1.Items.Add(plugin.name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                Databases.Plugin pluginmanager = new Databases.Plugin();
                foreach (var plugin in pluginmanager.GetPluginsByMinecraftVersion(version))
                {
                    if (plugin.name == name)
                    {
                        label1.Text = "Версия плагина: " + plugin.version + "\n";
                        label1.Text += "Оригинальная ссылка: " + plugin.link + "\n";
                        this.Size = new System.Drawing.Size(643, 259);
                        guna2GroupBox2.Visible = true;
                    }
                }
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                Databases.Plugin pluginmanager = new Databases.Plugin();
                foreach (var plugin in pluginmanager.GetPluginsByMinecraftVersion(version))
                {
                    if (plugin.name == name)
                    {
                        if (Directory.Exists("plugins"))
                        {
                            await Task.Factory.StartNew(() =>
                            {
                                using (WebClient wc = new WebClient())
                                {
                                    wc.DownloadFile(plugin.directlink, "plugins\\" + plugin.name + " [" + plugin.version + "].jar");
                                }
                            });
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string s = Regex.Match(label1.Text , "Оригинальная ссылка: (.*)").Groups[1].Value;
            if (s != "")
            {
                Clipboard.SetText(s);
            }
        }
    }
}
