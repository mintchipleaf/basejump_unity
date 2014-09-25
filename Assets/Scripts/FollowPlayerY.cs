using UnityEngine;
using System.Collections;

public class FollowPlayerY : MonoBehaviour {
	
	Transform player;
	
	void Start() {
		player = GameObject.Find("player").transform;
	}
	
	void Update() {
		transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
	}
}