using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public Vector2 speed = new Vector2(5,1);

	private Vector2 movement = new Vector2();
	private Vector2 movementY = new Vector2();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int inputX = 0;
		int inputY = 0;
	
		if (Input.GetKey ("up") || Input.GetKey("space")){
			inputY = 1;
			movement.y = rigidbody2D.velocity.y + 0.1f;
		}
		else {
			movement.y = rigidbody2D.velocity.y - 0.1f;
		}
		if (Input.GetKey ("left")){
			inputX = -1;
		}
		if (Input.GetKey ("right")){
			inputX = 1;
		}

		movement.x = (speed.x * inputX);

	}

	void FixedUpdate () {
		//rigidbody2D.velocity = movementX;

	https://www.dropbox.com/s/4dpqe5p6sc68bft/Screenshot%202014-09-24%2021.43.25.png?dl=0
			rigidbody2D.velocity = movement;
	}
	void OnGUI() {
		GUI.Label(new Rect(10, 10, 100, 20), movement.y.ToString());
	}
}
