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
    public partial class ModInstaller : Form
    {
        string version = "";
        public ModInstaller(string version)
        {
            this.version = version;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                Databases.Mod modmanager = new Databases.Mod();
                foreach (var mod in modmanager.GetModsByMinecraftVersion(version))
                {
                    if (mod.name == name)
                    {
                        using (WebClient wc = new WebClient())
                        {
                            if (Directory.Exists("mods"))
                            {
                                wc.DownloadFile(mod.directlink, "mods\\" + mod.name + " [" + mod.mcversion + "] [" + mod.version + "].jar");
                            }
                        }
                    }
                }
            }
        }

        private void ModInstaller_Load(object sender, EventArgs e)
        {
            Databases.Mod modmanager = new Databases.Mod();
            foreach (var mod in modmanager.GetModsByMinecraftVersion(version))
            {
                listBox1.Items.Add(mod.name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                Databases.Mod modmanager = new Databases.Mod();
                foreach (var mod in modmanager.GetModsByMinecraftVersion(version))
                {
                    if (mod.name == name)
                    {
                        label1.Text = "Майнкрафт версия: " + mod.mcversion + "\n";
                        label1.Text += "Версия мода: " + mod.version + "\n";
                        label1.Text += "Оригинальная ссылка: " + mod.link + "\n";
                    }
                }
            }
        }
    }
}
