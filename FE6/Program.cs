using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FE6
{
    //playersettings
    public class PlayerSettings
    {
        public string PlayerName { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public string[] Inventory { get; set; }
        public string LicenseKey { get; set; }
    }

    //settings
    public sealed class Settings
    {
        private static Settings instance;

        private Settings() { }

        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                }
                return instance;
            }
        }

        public PlayerSettings LoadSettings(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<PlayerSettings>(json);
            }

            //default settings if the file doesn't exist
            return new PlayerSettings();
        }

        public void SaveSettings(PlayerSettings settings, string filePath)
        {
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
    internal class Program
    {
     
        static void Main(string[] args)
        {
            string filePath = "player_settings.json";

            //singleton class to load and save settings
            PlayerSettings playerSettings = Settings.Instance.LoadSettings(filePath);

            //save modified settings
            Settings.Instance.SaveSettings(playerSettings, filePath);

        }
    }
}
