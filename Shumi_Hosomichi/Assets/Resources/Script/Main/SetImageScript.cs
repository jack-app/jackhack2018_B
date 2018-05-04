using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetImageScript : MonoBehaviour {

	public void SetImage(Sprite image)
    {
        GetComponent<Image>().sprite = image;
        GetComponent<RectTransform>().sizeDelta = new Vector2(image.bounds.size.x * transform.parent.GetComponent<RectTransform>().sizeDelta.y / image.bounds.size.y, 0);
    }
}
