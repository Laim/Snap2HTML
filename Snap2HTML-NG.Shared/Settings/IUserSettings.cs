
namespace Snap2HTMLNG.Shared.Settings
{
    internal interface IUserSettings
    {
        string GetString(string key);
        int GetInt(string key);
        bool GetBool(string key);
        void SetString(string key, string value);
        void SetInt(string key, int value);
        void SetBool(string key, bool value);
        bool SettingsFileExists();
    }
}
