using System;
using System.Collections.Specialized;
using System.IO;
using System.Xml;

namespace Snap2HTMLNG.Shared.Settings
{
    public class UserSettings : IUserSettings
    {
        private string SettingsFile;

        public UserSettings()
        {

            if(SettingsFile == null)
            {
                SettingsFile = $"{GetType().Name}.xml";
            }

            // Default Settings, see UserSettingsModel for key names.
            StringCollection settingsDefaults = new StringCollection
            {
                $"RootDirectory,{string.Empty}",
                $"Title,{string.Empty}",
                $"OutputFile,{string.Empty}",
                "SkipHiddenItems,true",
                "SkipSystemItems,true",
                "OpenInBrowserAfterCapture,false",
                "LinkFiles,false",
                $"LinkRoot,{string.Empty}",
                "SearchPattern,*",
                "DirectoriesOnly,false",
                "CheckForUpdates,false",
                "ExcludeEmptyDirectories,false",
                "FileDate,01/01/1753 00:00:00",
                "FileDate_Operator,0",
                "FileDate_Basis,0"
            };

            // Check if the file exists.  If it does, check if we have any new settings that need added to the settings file.
            // If it doesn't exist, create it.
            if (SettingsFileExists())
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(SettingsFile);

                XmlElement elm = doc.DocumentElement;
                XmlNodeList settings = elm.ChildNodes;

                StringCollection nodeNames = new StringCollection();

                // Get the name of each key in the settings file
                foreach(XmlNode node in settings)
                {
                    nodeNames.Add(node.Name);
                }

                // Loop through each setting in the existing settings file
                // to see if any new settings have been added to the app since the last load
                // This accounts for any app updates to prevent settings file's from breaking.

                string[] array;
                foreach (string setting in settingsDefaults)
                {
                    array = setting.Split(',');

                    string settingName = array[0];
                    string defaultValue = array[1];

                    if(!nodeNames.Contains(settingName))
                    {
                        XmlNode newSetting = doc.CreateElement(settingName);
                        newSetting.InnerText = defaultValue;
                        doc.DocumentElement.AppendChild(newSetting);
                        doc.Save(SettingsFile);
                    }
                }

            } else
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };

                using (XmlWriter writer = XmlWriter.Create(SettingsFile, settings))
                {
                    writer.WriteStartDocument();

                    writer.WriteComment(" See help.md for manual @ https://github.com/laim/snap2html-ng ");
                    writer.WriteStartElement("UserSettings");

                    // Loop through each of the items in the string collection and get the name and value
                    string[] array;
                    foreach(string setting in settingsDefaults)
                    {
                        array = setting.Split(',');

                        writer.WriteStartElement(array[0]); // setting name
                        writer.WriteString(array[1]); // setting value
                        writer.WriteEndElement();
                    }

                    writer.WriteEndDocument();
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// Returns the Setting Value as a Boolean
        /// </summary>
        /// <param name="key">Setting Key</param>
        /// <returns>Key value true or false, returns false if key not found</returns>
        public bool GetBool(string key)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(SettingsFile);
                XmlNode node = doc.SelectSingleNode($"//{GetType().Name}/{key}");

                bool value;
                if (node == null)
                {
                    value = false;
                }
                else
                {
                    value = bool.Parse(node.InnerText);
                }

                return value;
            } catch (Exception)
            {
                // This happens if someone has changed the settings value from true or false to something
                // like a random string that cannot be parsed
                return false;
            }
        }

        /// <summary>
        /// Returns the Setting Value as an Int
        /// </summary>
        /// <param name="key">Setting Key</param>
        /// <returns>Key value, returns 0 if key not found</returns>
        public int GetInt(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(SettingsFile);
            XmlNode node = doc.SelectSingleNode($"//{GetType().Name}/{key}");

            int value;
            if (node == null)
            {
                value = 0;
            }
            else
            {
                value = int.Parse(node.InnerText);
            }

            return value;
        }

        /// <summary>
        /// Returns the Setting Value as a string
        /// </summary>
        /// <param name="key">Setting Key</param>
        /// <returns>Key value, returns <see cref="string.Empty"/> if key not found</returns>
        public string GetString(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(SettingsFile);
            XmlNode node = doc.SelectSingleNode($"//{GetType().Name}/{key}");

            string value;
            if (node == null)
            {
                value = string.Empty;
            }
            else
            {
                value = node.InnerText;
            }

            return value;
        }

        public DateTime GetDateTime(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(SettingsFile);
            XmlNode node = doc.SelectSingleNode($"//{GetType().Name}/{key}");

            DateTime value;
            if (node == null)
            {
                value = DateTime.Today.AddYears(-900);
            }
            else
            {
                value = DateTime.Parse(node.InnerText);
            }

            return value;
        }

        /// <summary>
        /// Sets the value of the key to the passed parameter
        /// </summary>
        /// <param name="key">Key to update</param>
        /// <param name="value">Key Value</param>
        public void SetBool(string key, bool value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(SettingsFile);

            if(doc.SelectSingleNode($"//{GetType().Name}/{key}") == null)
            {
                XmlNode field = doc.CreateElement(key);
                field.InnerText = value.ToString();
                doc.DocumentElement.AppendChild(field);
                doc.Save(SettingsFile);
            } else
            {
                XmlNode node;
                node = doc.SelectSingleNode($"//{GetType().Name}/{key}");
                node.InnerText = value.ToString();
                doc.Save(SettingsFile);
            }
        }

        /// <summary>
        /// Sets the value of the key to the passed parameter
        /// </summary>
        /// <param name="key">Key to update</param>
        /// <param name="value">Key Value</param>
        public void SetInt(string key, int value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(SettingsFile);

            if (doc.SelectSingleNode($"//{GetType().Name}/{key}") == null)
            {
                XmlNode field = doc.CreateElement(key);
                field.InnerText = value.ToString();
                doc.DocumentElement.AppendChild(field);
                doc.Save(SettingsFile);
            }
            else
            {
                XmlNode node;
                node = doc.SelectSingleNode($"//{GetType().Name}/{key}");
                node.InnerText = value.ToString();
                doc.Save(SettingsFile);
            }
        }

        /// <summary>
        /// Sets the value of the key to the passed parameter
        /// </summary>
        /// <param name="key">Key to update</param>
        /// <param name="value">Key Value</param>
        public void SetString(string key, string value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(SettingsFile);

            if (doc.SelectSingleNode($"//{GetType().Name}/{key}") == null)
            {
                XmlNode field = doc.CreateElement(key);
                field.InnerText = value.ToString();
                doc.DocumentElement.AppendChild(field);
                doc.Save(SettingsFile);
            }
            else
            {
                XmlNode node;
                node = doc.SelectSingleNode($"//{GetType().Name}/{key}");
                node.InnerText = value.ToString();
                doc.Save(SettingsFile);
            }
        }

        /// <summary>
        /// Sets the value of the key to the passed parameter
        /// </summary>
        /// <param name="key">Key to update</param>
        /// <param name="value">Key Value</param>
        public void SetDateTime(string key, DateTime value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(SettingsFile);

            if (doc.SelectSingleNode($"//{GetType().Name}/{key}") == null)
            {
                XmlNode field = doc.CreateElement(key);
                field.InnerText = value.ToString();
                doc.DocumentElement.AppendChild(field);
                doc.Save(SettingsFile);
            }
            else
            {
                XmlNode node;
                node = doc.SelectSingleNode($"//{GetType().Name}/{key}");
                node.InnerText = value.ToString();
                doc.Save(SettingsFile);
            }
        }

        /// <summary>
        /// Checks if the Settings File Exists
        /// </summary>
        /// <returns>true or false, see <see cref="File.Exists(string)"/></returns>
        public bool SettingsFileExists()
        {
            return File.Exists(SettingsFile);
        }
    }
}
