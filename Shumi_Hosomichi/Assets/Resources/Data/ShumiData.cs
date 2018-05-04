using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/create ShumiData")]
public class ShumiData : ScriptableObject {

    public List<ShumiRecord> shumi_records;

    [System.Serializable]
	public class ShumiRecord
    {
        public string shumi_name;
        public string shumi_header;
        public Sprite shumi_image;
        public TextAsset shumi_content;
    }
}
