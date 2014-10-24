using UnityEngine;
using System.Collections;

public class FollowPlayerY : MonoBehaviour {
	
	public float offset = new float();

	Transform player;
	
	void Start() {
		player = GameObject.Find("Player").transform;
	}
	
	void Update() {
		transform.position = new Vector3(transform.position.x, player.position.y - offset, transform.position.z);
	}
}