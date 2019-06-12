using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Windows.Forms;
using System.IO;

public class SelectFolderButtonScript : MonoBehaviour {

    InputField path;

    public void Start()
    {
        path = GameObject.Find("FolderPath").GetComponent<InputField>();
    }

    public void OnClick()
    {
        Debug.Log(path.text);
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        fbd.Description = "作業用フォルダーを選択";
        fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
        fbd.SelectedPath = path.text;
        fbd.ShowNewFolderButton = false;
        if (fbd.ShowDialog() == DialogResult.OK)
        {
            Debug.Log(fbd.SelectedPath);
            path.text = fbd.SelectedPath;
        }
        else
        {
            Debug.Log("キャンセルされました");
        }
        fbd.Dispose();
    }
}
