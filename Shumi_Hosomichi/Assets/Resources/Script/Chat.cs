using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Chat : MonoBehaviour {
	//要素を追加するコンテント
	[SerializeField] RectTransform content;

	//生成する要素
	[SerializeField] RectTransform originalElement;
	[SerializeField] Text elementOriginalText;
 	[SerializeField] RectTransform botElement;
	[SerializeField] Text elementbotText;
    [SerializeField] ChangeChat contentChat;
private int i;
private int num=0;
private string bot;




	// テキスト入力フィールド
	[SerializeField] InputField input;
	private string[] bottext={"はじめまして！興味を持ってくれてありがとうございます！","10杯で3000円ほどの材料が必要かな～","ぜひオープンコーラライフを楽しんで！"};
	void Awake()
	{
		//（shiro）最初は何も表示されていないようにする
		originalElement.gameObject.SetActive (false);
		botElement.gameObject.SetActive(false);
	}

	public void OnSubmit()
	{
        // 入力フィールドを元に複製元のデータを改変
        // 入力フィールドは初期化する
        i = num % 3;
        num++;
		elementOriginalText.text = input.text;
		input.text = string.Empty;
		bot = bottext[i];
		elementbotText.text = bot;



		// content以下にoriginalElementを複製
		var element = GameObject.Instantiate<RectTransform> (originalElement);
		//（shiro）contentをelementの親にする
		element.SetParent (content, false);
		//（shiro）最後に表示されるようにする
		element.SetAsLastSibling ();
		//（shiro）画面上に表示する
		element.gameObject.SetActive (true);


		var botelement = GameObject.Instantiate<RectTransform>(botElement);
		botelement.SetParent (content, false);
		botelement.SetAsLastSibling ();
		botelement.gameObject.SetActive (true);

        /*Vector3 Content = transform.position;
		Vector3 ScrollView = transform.position;

		if(Content.y>ScrollView.y){

		}*/

        contentChat.flag = true;







	}
}
