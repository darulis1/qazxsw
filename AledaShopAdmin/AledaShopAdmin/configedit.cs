using System;
using System.Configuration;
using System.Windows.Forms;

namespace AledaShopAdmin
{
    class configedit
    {
        public bool tuscias = false;
        public void ReadAllSettings() //kolkas nenaudojamas
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    tuscias = true;                    
                }
                else
                {
                    tuscias = false;
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Raktas: {0} Reikšmė: {1}", key, appSettings[key]); //atkreipti demesi, kad atvaizdavimas vyksta konsolėje!!!
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        public void ReadAppSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Nerastas";
                MessageBox.Show(result);
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Negaliu nuskaityti rakto");
            }
        }

        public void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Negaliu įrašyti rakto");
            }
        }
    }
}
