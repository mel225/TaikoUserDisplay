using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class InitialDialogScript : MonoBehaviour {

    InputField path;
    Text currentFolder;

	// Use this for initialization
	void Start () {
        path = GameObject.Find("FolderPath").GetComponent<InputField>();
        currentFolder = GameObject.Find("subMessage").GetComponent<Text>();
        if (UserSettingScript.getWorkingFolder() == null)
        {
            this.gameObject.SetActive(true);
            path.text = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Debug.Log(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            Debug.Log(path.text);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
    
    public void Activate()
    {
        this.gameObject.SetActive(true);
        path.text = UserSettingScript.getWorkingFolder();
        currentFolder.text = "フォルダー名のみ指定した場合の親フォルダー：\n" + Directory.GetCurrentDirectory();
    }
}
