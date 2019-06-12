using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameChange : MonoBehaviour {
    
    public Dropdown Pdrop;
    public int TeamValue;
    public Image mydonImage;
    public Image nameImage;
    public ImageListScript imageList;

    // Use this for initialization
    void Start() {
        // get components
        imageList = GameObject.Find("GameManager").GetComponent<ImageListScript>();
        Pdrop = GetComponent<Dropdown>();
        foreach (Transform child in transform)
        {
            if (child.name.Equals("MydonImage"))
            {
                mydonImage = child.GetComponent<Image>();
            }
            if (child.name.Equals("NameImage"))
            {
                nameImage = child.GetComponent<Image>();
            }
        }

        // attach listener on value changed
		Pdrop.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(Pdrop);
        });
    }
	
    public void initObj()
    {

    }

    void DropdownValueChanged(Dropdown change)
    {

    }
}
