using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpandViewField : MonoBehaviour {
    public RectTransform inputText;
    public Text input;

	public void expand()
    {
        inputText.sizeDelta = new Vector2(inputText.sizeDelta.x, input.preferredHeight);
    }
}
