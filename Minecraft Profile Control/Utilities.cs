using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Minecraft_Profile_Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Minecraft_Profile_Control
{
    public static class Utilities
    {
        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: " + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        

        public static string GenerateLauncherProfilesText(string version, int ram)
        {
            DateTime currentTime = DateTime.UtcNow;
            string formattedTime = currentTime.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

            string output = "{\n" +
                "\"profiles\":{\n" +
                "\"0516cfec5ca4d568877d7f64a48f00ca\":{\n" +
                "\"created\":\"2024-07-23T21:07:54.248Z\",\n" +
                "\"icon\":\"Enchanting_Table\",\n" +
                $"\"javaArgs\":\"-Xmx{ram}G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M\",\n" +
                $"\"lastUsed\":\"{formattedTime}\",\n" +
                $"\"lastVersionId\":\"{version}\",\n" +
                "\"name\":\"Wybrana\"," +
                "\"type\":\"custom\"" +
                "}," +
                "\"acc17d8c662b4df84fe63d76fd50547e\":{\n\"created\":\"1970-01-01T00:00:00.000Z\",\n\"icon\":\"Dirt\",\n\"lastUsed\":\"1970-01-01T00:00:00.000Z\",\n\"lastVersionId\":\"latest-snapshot\",\n\"name\":\"\",\n\"type\":\"latest-snapshot\"\n},\n\"c1096699d3ed8ca99262103a9eaae5a7\":{\n\"created\":\"1970-01-02T00:00:00.000Z\",\n\"icon\":\"Grass\",\n\"lastUsed\":\"2024-06-25T16:51:17.158Z\",\n\"lastVersionId\":\"latest-release\",\n\"name\":\"\",\n\"type\":\"latest-release\"\n}\n},\n\"settings\":{\n\"crashAssistance\":true,\n\"enableAdvanced\":false,\n\"enableAnalytics\":true,\n\"enableHistorical\":false,\n\"enableReleases\":true,\n\"enableSnapshots\":false,\n\"keepLauncherOpen\":false,\n\"profileSorting\":\"ByLastPlayed\",\n\"showGameLog\":false,\n\"showMenu\":false,\n\"soundOn\":false\n},\n\"version\":3\n}";

            return output;
        }

        public static void SaveProfilesToXml(List<Form1.Profile> profiles, string directory)
        {
            var serializer = new XmlSerializer(typeof(List<Form1.Profile>));
            using (var writer = new StreamWriter(directory))
            {
                serializer.Serialize(writer, profiles);
            }
        }

        public static List<string> GetVersions()
        {
             List<string> versions = new List<string>() { "latest-release", "latest-snapshot" };

            foreach (string directory in Directory.GetDirectories($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/.minecraft/versions"))
            {
                string version_name = Path.GetFileName(directory);
                versions.Add(version_name);
            }

            return versions;
        }

        public static List<string> GetIcons()
        {
            List<string> icons = new List<string>() { "default", "fabric", "forge" };
            return icons;
        }


        public static string ReplaceCharacters(string input, string replacement)
        {
            
            List<string> charactersToReplace = new List<string>() { " ", "<", ">", ":", "\"", "/", "\\", "|", "?", "*" };
            foreach (string c in charactersToReplace)
            {
                input = input.Replace(c, replacement);
            }

            while (input.Substring(input.Length - 1, 1) == ".")
            {
                input = input.Substring(0, input.Length - 2);
            }

            return input;
        }
    }
}
