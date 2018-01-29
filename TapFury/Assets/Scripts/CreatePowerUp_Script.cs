using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePowerUp_Script : MonoBehaviour {

	public GameObject powerUp;
	public Transform parentOfPowerUp;
	public GM_Script score;
	public bool PowerUpOnScreen;

	// Use this for initialization
	void Start () {
		PowerUpOnScreen = false;
	}

	// Update is called once per frame
	void Update () {
		if (score.score == 3 && PowerUpOnScreen == false) {
			GameObject instantiatedPowerUp; 
			instantiatedPowerUp = Instantiate (powerUp, transform.position, Quaternion.identity);
			instantiatedPowerUp.transform.parent = parentOfPowerUp;
			PowerUpOnScreen = true;
		}
	}
}
