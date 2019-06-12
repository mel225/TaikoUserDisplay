using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UserSettingScript {

    public void start()
    {
        PlayerPrefs.DeleteAll();
    }

    public static string getWorkingFolder()
    {
        return PlayerPrefs.GetString("WorkingFolder", null);
    }
    public static void setWorkingFolder(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        PlayerPrefs.SetString("WorkingFolder", path);
        //Directory.SetCurrentDirectory(path + "\\..");
    }
}
