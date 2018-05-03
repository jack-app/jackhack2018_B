using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowShumi : MonoBehaviour {
    public ShumiData shumi_data;
    public SetTextScript title;
    public SetTextScript header;
    public SetTextScript content;
    public RectTransform contentTransform;

	// Use this for initialization
	void Start () {
        ShumiData.ShumiRecord shumi_record = shumi_data.shumi_records[2];
        title.SetText(shumi_record.shumi_name);
        header.SetText(shumi_record.shumi_header);
        content.SetText(shumi_record.shumi_content);
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(gameObject.GetComponent<RectTransform>().sizeDelta.x, 220 + contentTransform.sizeDelta.y - contentTransform.localPosition.y);
	}
}
