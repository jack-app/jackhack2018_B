using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour {
    public TextAsset textAsset;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Text>().text = textAsset.text;
	}
	
}
