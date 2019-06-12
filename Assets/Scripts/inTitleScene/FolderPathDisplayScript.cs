using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FolderPathDisplayScript : MonoBehaviour {

    Text path;

	// Use this for initialization
	void Start () {
        path = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        path.text = UserSettingScript.getWorkingFolder();
	}
}
