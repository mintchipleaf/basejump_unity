using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {
	public GameObject GMObject;

	private GameManager GM;

	// Use this for initialization
	void Awake () {
		GM = GMObject.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void Make ( float yPos, bool isLeft ) {
		 
	}
}
