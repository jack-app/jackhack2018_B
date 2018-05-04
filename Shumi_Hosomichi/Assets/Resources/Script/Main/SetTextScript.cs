using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTextScript : MonoBehaviour {

	public void SetText(TextAsset asset)
    {
        gameObject.GetComponent<Text>().text = asset.text;
        gameObject.GetComponent<Text>().rectTransform.sizeDelta = new Vector2(gameObject.GetComponent<Text>().rectTransform.sizeDelta.x, gameObject.GetComponent<Text>().preferredHeight);
    }

    public void SetText(string text)
    {
        gameObject.GetComponent<Text>().text = text;
    }
}
