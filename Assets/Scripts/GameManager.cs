using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	bool makeObstacle;

	// Use this for initialization
	void Awake () {
		makeObstacle = false;
	}
	
	// Update is called once per frame
	void Update () {
		camera.backgroundColor = Color.black;

		
	}

	void OnGui () {

	}
}
