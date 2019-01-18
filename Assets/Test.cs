using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	int hp= 100;
	int power= 25;
	int mp = 53;

	public void attack(){
		Debug.Log (this.power +"のダメージを与えた。");
	}	

	public void defence(int damage){
		Debug.Log (damage+ "のダメージを受けた。");
	}

	public void magic(){

		if (this.mp < 5)
			Debug.Log ("MPが足りないため魔法が使えない。");
		else {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int[] array= new int[5];

		array [0] = 10;
		array [1] = 20;
		array [2] = 30;
		array [3] = 40;
		array [4] = 50;

		for (int i = 0; i < 5; i++) {
			Debug.Log (array[i]);
		}

		for (int i = 4; i >= 0; i--) {
			Debug.Log (array[i]);
		}

		Boss lastboss = new Boss ();
		lastboss.attack ();
		lastboss.defence (3);

		for (int i = 0; i < 11; i++)
			lastboss.magic ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
