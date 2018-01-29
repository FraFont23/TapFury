using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Script : MonoBehaviour {

	public int score = 0;
	bool countedUp = false; 
	bool countedDown = false; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckScore ();
		CheckWinner ();
		print (score);
	}

	void CheckWinner(){
		if (score == 30) {
			print ("Player1 wins");
		} 
		if (score == -30) {
			print ("Player2 wins");
		}
	}

	public void CountUp(){
		score += 1;
		countedUp = true;
	}

	public void CountDown(){
		score -= 1;
		countedDown = true;
	}


	public void CheckScore (){
		if (countedUp == true) {
			MovementUp ();
			countedUp = false;
		} else if (countedDown == true) {
			MovementDown ();
			countedDown = false;
		}
	}

	public void MovementUp() {
		transform.Translate(Vector2.up * Time.deltaTime, Camera.main.transform);
	}

	public void MovementDown() {
		transform.Translate(Vector2.down * Time.deltaTime, Camera.main.transform);
	}
}
