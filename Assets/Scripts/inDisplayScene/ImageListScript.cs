using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageListScript : MonoBehaviour {

    public List<List<Sprite>> mydons = new List<List<Sprite>>();
    public List<List<Sprite>> names = new List<List<Sprite>>();
    public bool enable = false;
    
	// Update is called once per frame
	void Update () {
		
	}

    public Sprite getMydonImage(int tValue, int pValue)
    {
        return mydons[tValue][pValue];
    }

    public Sprite getNameImage(int tValue, int pValue)
    {
        return names[tValue][pValue];
    }
}
