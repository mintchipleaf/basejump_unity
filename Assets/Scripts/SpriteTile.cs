using UnityEngine;
using System.Collections;

public class SpriteTile : MonoBehaviour {

	private float ThisYBound;
	private float ThisYMin;
	private float CameraYMax;
	private float CameraYMin;

	// Use this for initialization
	void Start () {
		//Debug.Log(renderer.bounds.min.y);
		//Debug.Log(renderer.bounds.max.y);
		Debug.Log("extents y  "+this.renderer.bounds.extents.y);
		Debug.Log("camera y min  "+Camera.main.ViewportToWorldPoint(new Vector3(0,0)).y);
		Debug.Log("camera y max  "+Camera.main.ViewportToWorldPoint(new Vector3(1,1)).y);
	}
	
	// Update is called once per frame
	void Update () {

		ThisYMin = this.renderer.bounds.min.y;
		CameraYMax = Camera.main.ViewportToWorldPoint(new Vector3(1,1)).y;

		if (ThisYMin >= CameraYMax){
			ThisYBound = this.renderer.bounds.extents.y;
			CameraYMin = Camera.main.ViewportToWorldPoint(new Vector3(0,0)).y;

			this.transform.position = new Vector3(this.transform.position.x, CameraYMin - ThisYBound);
			//Try ThisY + Bounds.extents(y) >= ViewPortToWorldPoint(camera.main.transform.positon.y + camera's Bounds.extents(t))
		}
	}
}
