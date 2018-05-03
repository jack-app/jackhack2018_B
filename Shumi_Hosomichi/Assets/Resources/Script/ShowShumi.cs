using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowShumi : MonoBehaviour {
    public ShumiData shumi_data;
    public SetTextScript name;
    public SetTextScript header;
    public SetTextScript content;

	// Use this for initialization
	void Start () {
        ShumiData.ShumiRecord shumi_record = shumi_data.shumi_records[0];
        name.SetText(shumi_record.shumi_name);
        header.SetText(shumi_record.shumi_header);
        content.SetText(shumi_record.shumi_content);
	}
}
