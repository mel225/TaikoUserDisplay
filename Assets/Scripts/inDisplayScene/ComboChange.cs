using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboChange : MonoBehaviour
{

    [SerializeField]
    Dropdown Tname;

    [SerializeField]
    Dropdown Pname;

    [SerializeField]
    Image img;

    // Use this for initialization
    void Start()
    {
        Tname.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(Tname);
        });
    }

    void DropdownValueChanged(Dropdown change)
    {
    }
}