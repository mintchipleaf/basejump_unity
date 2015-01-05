using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpeedManager : MonoBehaviour {

	public GameObject player;
	public float speed;
	Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text>();
		speed = 40;
	}
	
	// Update is called once per frame
	void Update () {
		speed = 35 + Mathf.Abs(f:Mathf.Round(player.rigidbody2D.velocity.y));
		if (speed <= 40){
			speed = 40;
		}
		text.text = "kph\n" + speed;
	}
}
