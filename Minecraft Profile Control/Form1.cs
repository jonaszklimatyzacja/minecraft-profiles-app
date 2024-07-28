using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Minecraft_Profile_Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Diagnostics;
using Minecraft_Profile_Control.Properties;

namespace Minecraft_Profile_Control
{
    public partial class Form1 : Form
    {
        public class Profile
        {
            public string Name { get; set; }
            public string Dir { get; set; }
            public string Version { get; set; }
            public int Ram { get; set; }
            public string Icon { get; set; }
        }

        public string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/profile-control";
        public List<Profile> profiles = new List<Profile>();
        public string open_dir = "";
        public bool already_called = false;
        public int selected = 0;

        public void GenerateDefaultProfile()
        {
            Profile profile = new Profile();
            profile.Name = "latest release";
            profile.Dir = "latest-release";
            profile.Version = "latest-release";
            profile.Ram = 4;
            profile.Icon = "default";
            profiles.Add(profile);

            Utilities.SaveProfilesToXml(profiles, $"{path}/profiles.xml");

            if (!Directory.Exists($"{path}/profiles/latest-release/mods"))
            {
                Directory.CreateDirectory($"{path}/profiles/latest-release/mods");
            }

            if (!Directory.Exists($"{path}/profiles/latest-release/resourcepacks"))
            {
                Directory.CreateDirectory($"{path}/profiles/latest-release/resourcepacks");
            }
        }

        public void LoadProfilesData()
        {
            profiles_box.Items.Clear();
            profiles = new List<Profile>();

            if (!File.Exists($"{path}/profiles.xml"))
            {
                GenerateDefaultProfile();
            } else
            {
                //load info about profiles from profiles.xml
                StreamReader reader = new StreamReader($"{path}/profiles.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(reader.ReadToEnd());
                reader.Close();

                foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                {
                    Profile profile = new Profile
                    {
                        Name = node["Name"]?.InnerText,
                        Dir = node["Dir"]?.InnerText,
                        Version = node["Version"]?.InnerText,
                        Ram = int.Parse(node["Ram"]?.InnerText),
                        Icon = node["Icon"]?.InnerText
                    };

                    profiles.Add(profile);
                }
            }

            if(profiles.Count == 0)
            {
                GenerateDefaultProfile();
            }

            foreach (Profile profile in profiles)
            {
                profiles_box.Items.Add(profile.Name);
            }

            if (profiles_box.Items.Count > selected)
            {
                profiles_box.SelectedIndex = selected;
            } else {
                profiles_box.SelectedIndex = 0;
            }

            if (already_called)
            {
                UpdateDisplayedData();
            }

            already_called = true;
        }

        private void UpdateDisplayedData()
        {
            Dictionary<string, System.Drawing.Bitmap> icons = new Dictionary<string, System.Drawing.Bitmap>()
            {
                {"default", Resources.default_icon},
                {"fabric", Resources.fabric_icon},
                {"forge", Resources.forge_icon}
            };

            chosen_profile_name.Text = profiles[selected].Name;
            version_quantity_label.Text = profiles[selected].Version;
            ram_quantity_label.Text = $"{profiles[selected].Ram}";
            chosen_pictureBox.Image = icons[profiles[selected].Icon];
            open_dir = profiles[selected].Dir;
        }

        public Form1()
        {
            if (!Directory.Exists($"{path}/profiles"))
            {
                Directory.CreateDirectory($"{path}/profiles");
            }

            InitializeComponent();
            LoadProfilesData();

            if (File.Exists($"{path}/last.txt"))
            {
                //load the last chosen profile
                StreamReader reader = new StreamReader($"{path}/last.txt");
                string last_chosen = reader.ReadLine();
                reader.Close();
                profiles_box.SelectedIndex = 0;

                for (int i = 0; i < profiles.Count; i++)
                {
                    if (profiles[i].Name == last_chosen)
                    {
                        profiles_box.SelectedIndex = i;
                    }
                }
            }
        }
        
        private void profiles_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = profiles_box.SelectedIndex;
            UpdateDisplayedData();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            AddProfile add_profile_form = new AddProfile(this, profiles);
            add_profile_form.ReloadForm1 += LoadProfilesData;
            add_profile_form.Show();
        }

        private void manage_profile_button_Click(object sender, EventArgs e)
        {
            ProfileManager profile_manager_form = new ProfileManager(this, profiles, profiles_box.SelectedIndex);
            profile_manager_form.ReloadForm1 += LoadProfilesData;
            profile_manager_form.Show();
        }

        private void open_dir_button_Click(object sender, EventArgs e)
        {
            if (open_dir != "")
            {
                System.Diagnostics.Process.Start(path + "/profiles/" + open_dir);
            }
        }

        private void launch_button_Click(object sender, EventArgs e)
        {
            Profile selected_profile = profiles[profiles_box.SelectedIndex];
            string selected_profile_folder = path + "/profiles/" + selected_profile.Dir;
            string mods_folder = path + "/../" + "mods";
            string resourcepacks_folder = path + "/../" + "resourcepacks";

            //delete folders to get rid of their contents
            Directory.Delete(mods_folder, true);
            Directory.Delete(resourcepacks_folder, true);

            //copy designated profile's folders to game directory
            Utilities.DirectoryCopy(selected_profile_folder + "/mods", mods_folder, true);
            Utilities.DirectoryCopy(selected_profile_folder + "/resourcepacks", resourcepacks_folder, true);

            //generate json text to assign a chosen game version to the minecraft launcher settings and write it to launcher_profiles.json
            string output = Utilities.GenerateLauncherProfilesText(selected_profile.Version, selected_profile.Ram);
            using (StreamWriter writetext = new StreamWriter(path + "/../" + "launcher_profiles.json"))
            {
                writetext.WriteLine(output);
            }

            Process.Start("C:\\XboxGames\\Minecraft Launcher\\Content\\Minecraft.exe");
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int chosen_index = profiles_box.SelectedIndex;
            string chosen = profiles[chosen_index].Name;
            using (StreamWriter writetext = new StreamWriter(path + "/last.txt"))
            {
                writetext.WriteLine(chosen);
            }
        }
    }   
}