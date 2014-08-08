using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject spawnPoint;
	bool gravityIsEnabled = true;
	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		//Move player to spawn point
		gameObject.transform.position = spawnPoint.transform.position;

	}


	void OnTriggerEnter(Collider other){
		if (other.name == "Goal") {

			Application.LoadLevel("gameOver");

		}
	}

	// Update is called once per frame
	void Update () {


		
	}
}
