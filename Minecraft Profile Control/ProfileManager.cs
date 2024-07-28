using Minecraft_Profile_Control.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Minecraft_Profile_Control.Form1;

namespace Minecraft_Profile_Control
{
    public partial class ProfileManager : Form
    {
        
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/profile-control";
        public List<Profile> profiles = new List<Profile>();
        public int chosen = new int();
        public List<string> versions = Utilities.GetVersions();
        public List<string> icons = Utilities.GetIcons();
        Dictionary<string, System.Drawing.Bitmap> icons_dict = new Dictionary<string, System.Drawing.Bitmap>()
        {
            {"default", Resources.default_icon},
            {"fabric", Resources.fabric_icon},
            {"forge", Resources.forge_icon}
        };

        public ProfileManager(Form form1, List<Profile> received_profiles, int received_chosen)
        {
            InitializeComponent();
            profiles = received_profiles;
            chosen = received_chosen;

            //append all of downloaded versions to the comboBox and choose the right one
            foreach(string version in versions)
            {
                versions_comboBox.Items.Add(version);
            }
            versions_comboBox.SelectedIndex = versions.IndexOf(profiles[chosen].Version);

            //append all of icons' names to the comboBox and choose the right one
            foreach (string icon in icons)
            {
                icons_comboBox.Items.Add(icon);
            }
            icons_comboBox.SelectedIndex = icons.IndexOf(profiles[chosen].Icon);
            pictureBox.Image = icons_dict[profiles[chosen].Icon];
            profile_name_input.Text = profiles[chosen].Name;
            ram_input.Value = profiles[chosen].Ram;
        }

        public event Action ReloadForm1;

        private void icons_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Image = icons_dict[icons[icons_comboBox.SelectedIndex]];
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            profiles[chosen].Name = profile_name_input.Text;
            profiles[chosen].Version = versions[versions_comboBox.SelectedIndex];
            profiles[chosen].Ram = Decimal.ToInt32(Math.Floor(ram_input.Value));
            profiles[chosen].Icon = icons[icons_comboBox.SelectedIndex];

            Utilities.SaveProfilesToXml(profiles, $"{path}/profiles.xml");
            ReloadForm1?.Invoke();
            this.Close();
        }
        
        private void delete_button_Click(object sender, EventArgs e)
        {
            List<Profile> new_profiles = new List<Profile>();
            for (int i = 0; i < profiles.Count; i++)
            {
                if(i != chosen)
                {
                    new_profiles.Add(profiles[i]);
                }
            }

            Utilities.SaveProfilesToXml(new_profiles, $"{path}/profiles.xml");
            Directory.Delete($"{path}/profiles/{profiles[chosen].Dir}", true);
            ReloadForm1?.Invoke();
            this.Close();
        }
    }
}
