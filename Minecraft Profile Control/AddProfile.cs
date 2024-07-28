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
    public partial class AddProfile : Form
    {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/profile-control";
        public List<string> versions = Utilities.GetVersions();
        public List<string> icons = Utilities.GetIcons();
        Dictionary<string, System.Drawing.Bitmap> icons_dict = new Dictionary<string, System.Drawing.Bitmap>()
            {
                {"default", Resources.default_icon},
                {"fabric", Resources.fabric_icon},
                {"forge", Resources.forge_icon}
            };
        public Dictionary<string, bool> done = new Dictionary<string, bool>()
        {
            {"version", false},
            {"icon", false}
        };
        public List<Profile> profiles = new List<Profile>();

        public AddProfile(Form form1, List<Profile> received_profiles)
        {
            InitializeComponent();

            profiles = received_profiles;

            foreach (string version in versions)
            {
                versions_comboBox.Items.Add(version);
            }

            foreach (string icon in icons)
            {
                icons_comboBox.Items.Add(icon);
            }

        }

        public event Action ReloadForm1;

        private void icons_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Image = icons_dict[icons[icons_comboBox.SelectedIndex]];
            done["icon"] = true;
        }

        private void versions_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            done["version"] = true;
        }

        private void create_button_Click(object sender, EventArgs e)
        {

            string dir = Utilities.ReplaceCharacters(profile_name_input.Text, "-");
            bool isDirGood = true;
            bool isNameGood = true;

            foreach (string directory in Directory.GetDirectories($"{path}/profiles"))
            {
                string profile_name = Path.GetFileName(directory);
                if(dir == profile_name)
                {
                    isDirGood = false;
                }
            }

            foreach(Profile profile in profiles)
            {
                if(profile_name_input.Text == profile.Name)
                {
                    isNameGood = false;
                }
            }

            if (isDirGood && isNameGood && done["version"])
            {
                Profile new_profile = new Profile();
                new_profile.Name = profile_name_input.Text;
                new_profile.Dir = dir;
                new_profile.Version = versions[versions_comboBox.SelectedIndex];
                new_profile.Ram = Decimal.ToInt32(Math.Floor(ram_input.Value));
                
                if (done["icon"])
                {
                    new_profile.Icon = icons[icons_comboBox.SelectedIndex];       
                } else
                {
                    new_profile.Icon = icons[0];
                }

                profiles.Add(new_profile);
                Directory.CreateDirectory($"{path}/profiles/{new_profile.Dir}/mods");
                Directory.CreateDirectory($"{path}/profiles/{new_profile.Dir}/resourcepacks");

                Utilities.SaveProfilesToXml(profiles, $"{path}/profiles.xml");
                ReloadForm1?.Invoke();
                this.Close();
            }
        }
    }
}
