using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Script : MonoBehaviour {

	public int score = 0;
	public CounterScript counter01;
	public CounterScript counter02;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckScore ();
		CheckWinner ();
	}

	void CheckWinner(){
		if (score == 30) {
			print ("Player1 wins");
		} 
		if (score == -30) {
			print ("Player2 wins");
		}
	}


	public void CheckScore (){
		if (counter01.countedUp == true) {
			MovementUp ();
			counter01.countedUp = false;
		} else if (counter02.countedDown == true) {
			MovementDown ();
			counter02.countedDown = false;
		}
	}

	public void MovementUp() {
		transform.Translate(Vector2.up * Time.deltaTime, Camera.main.transform);
	}

	public void MovementDown() {
		transform.Translate(Vector2.down * Time.deltaTime, Camera.main.transform);
	}
}
