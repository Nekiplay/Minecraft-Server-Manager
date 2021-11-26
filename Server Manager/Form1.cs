using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Server_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Databases.Core coremanager = new Databases.Core();
        Databases.Plugin pluginmanager = new Databases.Plugin();
        Databases.Mod modmanager = new Databases.Mod();
        private void Form1_Load(object sender, EventArgs e)
        {
            var core = coremanager.GetCore(Environment.CurrentDirectory);
            if (core != null)
            {
                this.label1.Text = "Ядро: " + core.name;
                this.label2.Text = "Версия майнкрафта: " + core.mcversion.ToVersion();
            }

            if (Directory.Exists(Environment.CurrentDirectory + "\\plugins"))
            {
                var plugins = pluginmanager.GetPlugins(Environment.CurrentDirectory + "\\plugins");
                foreach (var plugin in plugins)
                {
                    listBox1.Items.Add(plugin.name);
                }
            }

            if (Directory.Exists(Environment.CurrentDirectory + "\\mods"))
            {
                var mods = modmanager.GetMods(Environment.CurrentDirectory + "\\mods");
                foreach (var mod in mods)
                {
                    listBox2.Items.Add(mod.name);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var core = coremanager.GetCore(Environment.CurrentDirectory);
            if (core != null)
            {
                Process.Start("cmd.exe", "/k java.exe -Xmx1024M -Xms1024M -jar \"" + core.path + "\" nogui");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var core = coremanager.GetCore(Environment.CurrentDirectory);
            if (core != null)
            {
                PluginInstaller pluginInstaller = new PluginInstaller(core.mcversion);
                pluginInstaller.Show();
            }
            else
            {
                MessageBox.Show("Ядро сервера не найдено");
            }
        }

        private void modmanagerButton_Click(object sender, EventArgs e)
        {
            var core = coremanager.GetCore(Environment.CurrentDirectory);
            if (core != null)
            {
                ModInstaller modInstaller = new ModInstaller(core.mcversion);
                modInstaller.Show();
            }
            else
            {
                MessageBox.Show("Ядро сервера не найдено");
            }
        }
    }
}
