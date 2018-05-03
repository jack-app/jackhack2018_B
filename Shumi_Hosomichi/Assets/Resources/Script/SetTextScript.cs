using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTextScript : MonoBehaviour {

	public void SetText(TextAsset asset)
    {
        gameObject.GetComponent<Text>().text = asset.text;
    }

    public void SetText(string text)
    {
        gameObject.GetComponent<Text>().text = text;
    }
}
