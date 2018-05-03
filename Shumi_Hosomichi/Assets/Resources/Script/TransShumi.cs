using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransShumi : MonoBehaviour {
    float countTime =0f;
    public GameObject ShumiPrefab;
    public RectTransform timer;
    public RectTransform timerParent;

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        if(countTime > 10f)
        {
            countTime = 0f;
            GameObject part1 = GameObject.Find("ShumiObject");
            part1.GetComponent<Animator>().SetTrigger("trans");
            GameObject part2=Instantiate(ShumiPrefab, new Vector3(800, 0, 0), Quaternion.identity, transform);
            part2.name = "ShumiObject";
            part2.transform.SetSiblingIndex(1);
            part2.GetComponent<MoveShumiObject>().canvas = GetComponent<Animator>();
            //part2.GetComponent<Animator>().SetTrigger("trans");
            //Destroy(part1);
        }
        timer.sizeDelta = new Vector2(timerParent.sizeDelta.x * (countTime / 10f), timer.sizeDelta.y);
    }
}
