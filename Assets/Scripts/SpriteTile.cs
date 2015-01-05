using UnityEngine;
using System.Collections;

public class SpriteTile : MonoBehaviour {
	public Object sprite;		//The sprite prefab to use. Drag a prefab into the inspector

	private float ThisYMin;
	private float ThisYBound;
	private float CameraYMin;
	private float CameraYMax;

	private bool instantiated;	//Used to store if the next sprite has been instantiated
	
	void Awake () {
		instantiated = false;
		//debug();
	}

	void Update () {
		ThisYMin = this.renderer.bounds.min.y;									//Bottom y pos of current sprite
		ThisYBound = this.renderer.bounds.extents.y;							//Half height of current sprite
		CameraYMin = Camera.main.ViewportToWorldPoint(new Vector3(-1,-1)).y;	//Bottom y pos of camera
		CameraYMax = Camera.main.ViewportToWorldPoint(new Vector3(1,1)).y;		//Top y pos of camera

		//If the next sprite hasn't been instantiated, and bottom of this one is at or above bottom of screen
		if(!instantiated && ThisYMin >= CameraYMin){
			Instantiate(sprite, new Vector3(this.transform.position.x, ThisYMin - (ThisYBound), this.transform.position.z), Quaternion.identity); //Instantiate next sprite ThisYBound units below current y pos
			instantiated = true;	//Next sprite has been instantiated
		}

		if(ThisYMin > CameraYMax){
			Destroy(gameObject);	//EMERGENCY DESTRUCTION SYSTEM
		}
	}

	/*void debug(){		
		Debug.Log("This y min " +renderer.bounds.min.y);
		Debug.Log("This y max " + renderer.bounds.max.y);
		Debug.Log("extents y  "+this.renderer.bounds.extents.y);
		Debug.Log("camera y min  "+Camera.main.ViewportToWorldPoint(new Vector3(-1,-1)).y);
		Debug.Log("camera y max  "+Camera.main.ViewportToWorldPoint(new Vector3(1,1)).y);
	}*/
}
