using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

public class OkButtonScript : MonoBehaviour {

    GameObject panel;
    InputField path;

	// Use this for initialization
	void Start () {
        panel = GameObject.Find("InitialDialog");
        path = GameObject.Find("FolderPath").GetComponent<InputField>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        if (!Directory.Exists(path.text))
        {
            if(path.text == "")
            {
                EditorUtility.DisplayDialog("パスがないよ。", "空白です。", "はい。");
                return;
            }
            if(!EditorUtility.DisplayDialog("フォルダーねぇじゃん。", "指定したフォルダーが存在しません。\n新規作成しますか？", "はい", "いいえ"))
            {
                return;
            }
        }
        path.text = Path.GetFullPath(path.text);
        UserSettingScript.setWorkingFolder(path.text);
        panel.SetActive(false);
    }

}
