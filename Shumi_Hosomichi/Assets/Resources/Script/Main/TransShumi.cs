using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransShumi : MonoBehaviour {
    float countTime =0f;
    public GameObject ShumiPrefab;
    public GameObject FinishPrefab;
    public RectTransform timer;
    public RectTransform timerParent;
    public Text ShumiNumText;
    public ShumiData shumiData;
    public float time = 5f;
    bool goflag = true;

    void Start()
    {
        ShumiNumText.text = (GetComponentInChildren<ShowShumi>().GetShumiNumber()) + "/" + shumiData.shumi_records.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if(goflag)
            countTime += Time.deltaTime;

        if(countTime > time)
        {
            countTime = 0f;
            GameObject part1 = GameObject.Find("ShumiObject");
            //part1.GetComponent<Animator>().SetTrigger("trans");
            GameObject part2;
            if(shumiData.shumi_records.Count <= GetComponentInChildren<ShowShumi>().GetShumiNumber())
            {
                part2 = Instantiate(FinishPrefab, new Vector3(800, 0, 0), Quaternion.identity, transform);
                part2.name = "FinishObject";
                GetComponent<Animator>().SetBool("ClearStatus", true);
                SetGoFlag(false);
            }
            else
            {
                part2 = Instantiate(ShumiPrefab, new Vector3(800, 0, 0), Quaternion.identity, transform);
                part2.name = "ShumiObject";
                ShumiNumText.text = (GetComponentInChildren<ShowShumi>().GetShumiNumber() + 1) + "/" + shumiData.shumi_records.Count;
            }
            part2.name = "ShumiObject";
            part2.transform.SetSiblingIndex(1);
            part2.GetComponent<Animator>().SetBool("TransFlag", true);
            part2.GetComponent<MoveShumiObject>().canvas = gameObject;
            part2.GetComponent<MoveShumiObject>().oldObject = part1;
            //part2.GetComponent<Animator>().SetTrigger("trans");
            //Destroy(part1);
        }
        timer.sizeDelta = new Vector2(timerParent.sizeDelta.x * (countTime / time), timer.sizeDelta.y);
    }

    public void SetGoFlag(bool flag)
    {
        goflag = flag;
    }
}
