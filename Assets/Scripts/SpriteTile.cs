using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	private Vector3 ThisY;
	private Vector3 CameraY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ThisY = this.transform.position.y;
		CameraY = Camera.main.transform.position;
		if (ThisY >= CameraY){

			//Try ThisY + Bounds.extents(y) >= ViewPortToWorldPoint(camera.main.transform.positon.y + camera's Bounds.extents(t))
		}
	}
}
