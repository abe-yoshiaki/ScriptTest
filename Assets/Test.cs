using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int mp = 53;

	public void magic(){
		this.mp -= 5;

		if (this.mp < 0) {
			Debug.Log ("MPが足りないため魔法が使えない。");
			return;
		}
		Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//課題:配列arrayを初期化
		int[] array = { 10, 20, 30, 40, 50 };

		//課題:配列要素を順番に表示
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		//課題:配列要素を逆順に表示
		for (int i = array.Length -1; 0 <= i; i--) {
			Debug.Log (array [i]);
		}

		Boss lastboss = new Boss();

		for (int i = 0; i <= 10; i++) {
			lastboss.magic();
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
