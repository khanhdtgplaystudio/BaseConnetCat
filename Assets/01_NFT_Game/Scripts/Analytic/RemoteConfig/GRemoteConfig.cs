using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UniRx;
using System.Globalization;
using Newtonsoft.Json;


public class ReloadConfig
{

}

public class ReloadPlayfabConfig
{

}

public class GRemoteConfig
{
    
    #region Variables

    //private static bool LoadedConfig;
    //private static bool LoadingConfig;
    private static bool isInit;
    private static Dictionary<string, string> playfabConfig = new Dictionary<string, string>();
    public static bool InitSuccess;

    #endregion Variables

    #region Public Methods


    public static bool PlayfabJsonConfig<T>(string key, out T result)
    {
        string input;
        if (!playfabConfig.ContainsKey(key) ||
            string.IsNullOrEmpty(input = playfabConfig[key]))
        {
            result = default;
            return false;

        }

        try
        {
            result = JsonConvert.DeserializeObject<T>(input);
            return true;
        }
        catch (Exception ex)
        {
            Debug.LogError($"GetJsonConfig {typeof(T)} , key {key}, exception: {ex.Message}");
            result = default;
            return false;
        }
    }

    public static string PlayfabStringConfig(string key, string defaultValue)
    {
        return playfabConfig.ContainsKey(key) ? playfabConfig[key] : defaultValue;
    }

    public static int PlayfabIntConfig(string key, int defaultVal)
    {
        try
        {
            return playfabConfig.ContainsKey(key) ? int.Parse(playfabConfig[key]) : defaultVal;
        }
        catch (Exception)
        {
            return defaultVal;
        }
    }

    public static float PlayfabFloatConfig(string key, float defaultVal)
    {
        try
        {
            return playfabConfig.ContainsKey(key) ? float.Parse(playfabConfig[key], CultureInfo.InvariantCulture) : defaultVal;
        }
        catch (Exception)
        {
            return defaultVal;
        }
    }

    public static bool PlayfabBoolConfig(string key, bool defaultVal)
    {
        try
        {
            return playfabConfig.ContainsKey(key) ? int.Parse(playfabConfig[key]) == 1 : defaultVal;
        }
        catch (Exception)
        {
            return defaultVal;
        }
    }

    public static bool GetRocketJsonConfig<T>(string key, out T result)
    {
        string input;
        if (!playfabConfig.ContainsKey(key) ||
            string.IsNullOrEmpty(input = playfabConfig[key]))
        {
            result = default;
            return false;
        }

        try
        {
            result = JsonConvert.DeserializeObject<T>(input);
            return true;
        }
        catch (Exception ex)
        {
            Debug.LogError($"GetJsonConfig {typeof(T)} , key {key}, exception: {ex.Message}");
            result = default;
            return false;
        }
    }

    #endregion Public Methods

    #region Private Methods

    public static void OnLoadConfig(Dictionary<string, string> Data)
    {
        if (Data != null)
        {
            playfabConfig = Data;
            MessageBroker.Default.Publish(new ReloadPlayfabConfig());
            GObservable.GConfigReload.OnNext(Unit.Default);
            //PlayerPrefs.SetString("CONFIG_CACHED", JsonUtility.ToJson(Data));
        }
    }



    //static Dictionary<string, object> defaults = new Dictionary<string, object>();
   
    private static void DebugLog(string s)
    {
        Debug.Log(s);
    }

    #endregion Private Methods

}
