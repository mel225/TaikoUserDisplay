using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFolderButtonScript : MonoBehaviour {

    GameObject panel;

	// Use this for initialization
	void Start () {
        panel = GameObject.Find("InitialDialog");
	}

    public void OnClick()
    {
        panel.GetComponent<InitialDialogScript>().Activate();
    }
}
