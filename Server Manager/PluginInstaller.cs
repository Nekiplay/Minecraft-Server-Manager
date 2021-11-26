using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Manager
{
    public partial class PluginInstaller : Form
    {
        public PluginInstaller()
        {
            InitializeComponent();
        }

        private void PluginInstaller_Load(object sender, EventArgs e)
        {
            Databases.Plugin pluginmanager = new Databases.Plugin();
            foreach (var plugin in pluginmanager.plugins)
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
                foreach (var plugin in pluginmanager.plugins)
                {
                    if (plugin.name == name)
                    {
                        label1.Text = "Майнкрафт версия: " + plugin.mcversion + "\n";
                        label1.Text += "Версия плагина: " + plugin.version + "\n";
                        label1.Text += "Оригинальная ссылка: " + plugin.link + "\n";
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                Databases.Plugin pluginmanager = new Databases.Plugin();
                foreach (var plugin in pluginmanager.plugins)
                {
                    if (plugin.name == name)
                    {
                        using (WebClient wc = new WebClient())
                        {
                            if (Directory.Exists("plugins"))
                            {
                                wc.DownloadFile(plugin.directlink, "plugins\\" + plugin.name + " [" + plugin.mcversion + "] [" + plugin.version + "].jar");
                            }
                        }
                    }
                }
            }
        }
    }
}
