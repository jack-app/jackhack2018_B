using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowShumi : MonoBehaviour {
    public ShumiData shumi_data;
    public SetTextScript title;
    public SetTextScript header;
    public SetTextScript content;
    public SetImageScript topImage;
    public RectTransform contentTransform;
    static int shumi_number = 0;

	// Use this for initialization
	void Start () {
        ShumiData.ShumiRecord shumi_record = shumi_data.shumi_records[shumi_number];
        title.SetText(shumi_record.shumi_name);
        header.SetText(shumi_record.shumi_header);
        content.SetText(shumi_record.shumi_content);
        topImage.SetImage(shumi_record.shumi_image);
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(gameObject.GetComponent<RectTransform>().sizeDelta.x, 430 + contentTransform.sizeDelta.y - contentTransform.localPosition.y);
        shumi_number++;
	}

    public int GetShumiNumber()
    {
        return shumi_number;
    }
}
