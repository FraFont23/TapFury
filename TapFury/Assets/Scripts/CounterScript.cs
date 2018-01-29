using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScript : MonoBehaviour {

	public bool countedUp; 
	public bool countedDown; 
	public GM_Script score;

	// Use this for initialization
	void Start () {
		countedUp = false;
		countedDown = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CountUp(){
		score.score += 1;
		countedUp = true;
		print (score);
	}

	public void CountDown(){
		score.score -= 1;
		countedDown = true;
		print (score);
	}
}
